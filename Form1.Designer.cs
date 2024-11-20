namespace MQTTClientApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstReceived;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.ListBox lstPublish;
        private System.Windows.Forms.Label lblPublish;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblPublishMessage;
        private System.Windows.Forms.Label lblReceivedMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstReceived = new System.Windows.Forms.ListBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.lstPublish = new System.Windows.Forms.ListBox();
            this.lblPublish = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblPublishMessage = new System.Windows.Forms.Label();
            this.lblReceivedMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lstReceived
            this.lstReceived.FormattingEnabled = true;
            this.lstReceived.Location = new System.Drawing.Point(15, 315);
            this.lstReceived.Name = "lstReceived";
            this.lstReceived.Size = new System.Drawing.Size(400, 173);
            this.lstReceived.TabIndex = 0;

            // lblTopic
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(12, 18);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(37, 13);
            this.lblTopic.TabIndex = 1;
            this.lblTopic.Text = "Topic:";

            // lstPublish
            this.lstPublish.FormattingEnabled = true;
            this.lstPublish.Location = new System.Drawing.Point(15, 107);
            this.lstPublish.Name = "lstPublish";
            this.lstPublish.Size = new System.Drawing.Size(400, 173);
            this.lstPublish.TabIndex = 2;
 
            // lblPublish
            this.lblPublish.AutoSize = true;
            this.lblPublish.Location = new System.Drawing.Point(12, 62);
            this.lblPublish.Name = "lblPublish";
            this.lblPublish.Size = new System.Drawing.Size(53, 13);
            this.lblPublish.TabIndex = 3;
            this.lblPublish.Text = "Message:";

            // btnPublish
            this.btnPublish.Location = new System.Drawing.Point(337, 57);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 4;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);

            // txtTopic
            this.txtTopic.Location = new System.Drawing.Point(55, 15);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(357, 20);
            this.txtTopic.TabIndex = 5;

            // txtMessage
            this.txtMessage.Location = new System.Drawing.Point(71, 59);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(260, 20);
            this.txtMessage.TabIndex = 6;

            // lblPublishMessage
            this.lblPublishMessage.AutoSize = true;
            this.lblPublishMessage.Location = new System.Drawing.Point(12, 91);
            this.lblPublishMessage.Name = "lblPublishMessage";
            this.lblPublishMessage.Size = new System.Drawing.Size(90, 13);
            this.lblPublishMessage.TabIndex = 7;
            this.lblPublishMessage.Text = "Publish Message:";
            this.lblPublishMessage.Click += new System.EventHandler(this.label1_Click);

            // lblReceivedMessage
            this.lblReceivedMessage.AutoSize = true;
            this.lblReceivedMessage.Location = new System.Drawing.Point(12, 299);
            this.lblReceivedMessage.Name = "lblReceivedMessage";
            this.lblReceivedMessage.Size = new System.Drawing.Size(101, 13);
            this.lblReceivedMessage.TabIndex = 8;
            this.lblReceivedMessage.Text = "Received message:";

            // Form1
            this.ClientSize = new System.Drawing.Size(430, 502);
            this.Controls.Add(this.lblReceivedMessage);
            this.Controls.Add(this.lblPublishMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.lblPublish);
            this.Controls.Add(this.lstPublish);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lstReceived);
            this.Name = "Form1";
            this.Text = "MQTT Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
