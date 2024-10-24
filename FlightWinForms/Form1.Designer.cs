namespace FlightWinForms
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      button1 = new Button();
      listBox1 = new ListBox();
      label1 = new Label();
      comboBox1 = new ComboBox();
      button2 = new Button();
      SuspendLayout();
      // 
      // button1
      // 
      button1.Location = new Point(42, 54);
      button1.Name = "button1";
      button1.Size = new Size(121, 23);
      button1.TabIndex = 0;
      button1.Text = "Write To File";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // listBox1
      // 
      listBox1.FormattingEnabled = true;
      listBox1.ItemHeight = 15;
      listBox1.Location = new Point(224, 65);
      listBox1.Name = "listBox1";
      listBox1.Size = new Size(275, 289);
      listBox1.TabIndex = 1;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(57, 111);
      label1.Name = "label1";
      label1.Size = new Size(38, 15);
      label1.TabIndex = 2;
      label1.Text = "label1";
      // 
      // comboBox1
      // 
      comboBox1.FormattingEnabled = true;
      comboBox1.Location = new Point(42, 158);
      comboBox1.Name = "comboBox1";
      comboBox1.Size = new Size(121, 23);
      comboBox1.TabIndex = 3;
      // 
      // button2
      // 
      button2.Location = new Point(42, 217);
      button2.Name = "button2";
      button2.Size = new Size(75, 23);
      button2.TabIndex = 4;
      button2.Text = "button2";
      button2.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(button2);
      Controls.Add(comboBox1);
      Controls.Add(label1);
      Controls.Add(listBox1);
      Controls.Add(button1);
      Name = "Form1";
      Text = "Form1";
      Load += Form1_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button button1;
    private ListBox listBox1;
    private Label label1;
    private ComboBox comboBox1;
    private Button button2;
  }
}
