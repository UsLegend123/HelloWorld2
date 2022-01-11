namespace HelloWorld
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.lblDisplayInfo = new System.Windows.Forms.Label();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnGoodbye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Location = new System.Drawing.Point(196, 74);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(75, 23);
            this.btnHelloWorld.TabIndex = 0;
            this.btnHelloWorld.Text = "Say Hello";
            this.btnHelloWorld.UseVisualStyleBackColor = true;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // lblDisplayInfo
            // 
            this.lblDisplayInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayInfo.Location = new System.Drawing.Point(70, 39);
            this.lblDisplayInfo.Name = "lblDisplayInfo";
            this.lblDisplayInfo.Size = new System.Drawing.Size(201, 23);
            this.lblDisplayInfo.TabIndex = 1;
            this.lblDisplayInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(70, 74);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(107, 23);
            this.btnManager.TabIndex = 2;
            this.btnManager.Text = "Display Message";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnGoodbye
            // 
            this.btnGoodbye.Location = new System.Drawing.Point(70, 103);
            this.btnGoodbye.Name = "btnGoodbye";
            this.btnGoodbye.Size = new System.Drawing.Size(107, 22);
            this.btnGoodbye.TabIndex = 3;
            this.btnGoodbye.Text = "Say Goodbye";
            this.btnGoodbye.UseVisualStyleBackColor = true;
            this.btnGoodbye.Click += new System.EventHandler(this.btnGoodbye_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 153);
            this.Controls.Add(this.btnGoodbye);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.lblDisplayInfo);
            this.Controls.Add(this.btnHelloWorld);
            this.Name = "Form1";
            this.Text = "Hello World";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Label lblDisplayInfo;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnGoodbye;
    }
}

