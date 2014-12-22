namespace SmartDish
{
  partial class FStudio
  {
    /// <summary>
    /// Требуется переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Обязательный метод для поддержки конструктора - не изменяйте
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.experimentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mea256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.connectToDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.deviceToolStripMenuItem,
            this.experimentsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // deviceToolStripMenuItem
      // 
      this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.mea256ToolStripMenuItem});
      this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
      this.deviceToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.deviceToolStripMenuItem.Text = "Device";
      // 
      // settingsToolStripMenuItem
      // 
      this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
      this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.settingsToolStripMenuItem.Text = "Settings";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
      this.aboutToolStripMenuItem.Text = "About";
      // 
      // experimentsToolStripMenuItem
      // 
      this.experimentsToolStripMenuItem.Name = "experimentsToolStripMenuItem";
      this.experimentsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
      this.experimentsToolStripMenuItem.Text = "Experiments";
      // 
      // cameraToolStripMenuItem
      // 
      this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.connectToDeviceToolStripMenuItem});
      this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
      this.cameraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.cameraToolStripMenuItem.Text = "Camera";
      // 
      // connectToolStripMenuItem
      // 
      this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
      this.connectToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
      this.connectToolStripMenuItem.Text = "Connect to avi file ";
      // 
      // mea256ToolStripMenuItem
      // 
      this.mea256ToolStripMenuItem.Name = "mea256ToolStripMenuItem";
      this.mea256ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.mea256ToolStripMenuItem.Text = "Mea 256";
      // 
      // connectToDeviceToolStripMenuItem
      // 
      this.connectToDeviceToolStripMenuItem.Name = "connectToDeviceToolStripMenuItem";
      this.connectToDeviceToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
      this.connectToDeviceToolStripMenuItem.Text = "Connect to device";
      // 
      // FStudio
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1022, 350);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FStudio";
      this.Text = "Smart dish Studio ";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem experimentsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem connectToDeviceToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mea256ToolStripMenuItem;
  }
}

