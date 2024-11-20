using System;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTTClientApp
{
    public partial class Form1 : Form
    {
        private MqttClient mqttClient;

        public Form1()
        {
            InitializeComponent();
            mqttClient = new MqttClient("localhost");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            ConnectToBroker();
        }

        private void ConnectToBroker()
        {
            try
            {
                mqttClient.Connect(Guid.NewGuid().ToString());
                if (mqttClient.IsConnected)
                {
                    AppendReceivedMessage("", "Connected to broker.");
                    mqttClient.Subscribe(new string[] { "#" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to the MQTT broker. Error: " + ex.Message);
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            string topic = txtTopic.Text.Trim();
            string message = txtMessage.Text;
            byte[] payload = Encoding.UTF8.GetBytes(message);
            mqttClient.Publish(topic, payload, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false);
            AppendPublishedMessage(topic, message);
        }

        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string message = Encoding.UTF8.GetString(e.Message);
            string topic = e.Topic;
            AppendReceivedMessage(topic, message);
        }

        private void AppendReceivedMessage(string topic, string message)
        {
            Invoke(new Action(() =>
            {
                lstReceived.Items.Add($"Topic: {topic}, Message: {message}");
            }));
        }

        private void AppendPublishedMessage(string topic, string message)
        {
            Invoke(new Action(() =>
            {
                lstPublish.Items.Add($"Topic: {topic}, Message: {message}");
            }));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
