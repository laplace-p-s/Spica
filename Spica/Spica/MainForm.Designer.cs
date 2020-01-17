namespace Spica
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimerDayLabel = new System.Windows.Forms.Label();
            this.TimerTimeLabel = new System.Windows.Forms.Label();
            this.StartWorkButton = new System.Windows.Forms.Button();
            this.FinishWorkButton = new System.Windows.Forms.Button();
            this.Lasted20Label = new System.Windows.Forms.Label();
            this.Lasted20DataGridView = new System.Windows.Forms.DataGridView();
            this.RecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoundRecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountTimer = new System.Windows.Forms.Timer(this.components);
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Lasted20DataGridView)).BeginInit();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerDayLabel
            // 
            this.TimerDayLabel.AutoSize = true;
            this.TimerDayLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimerDayLabel.Location = new System.Drawing.Point(184, 102);
            this.TimerDayLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TimerDayLabel.Name = "TimerDayLabel";
            this.TimerDayLabel.Size = new System.Drawing.Size(395, 38);
            this.TimerDayLabel.TabIndex = 1;
            this.TimerDayLabel.Text = "yyyy年 MM月 dd日 (月)";
            // 
            // TimerTimeLabel
            // 
            this.TimerTimeLabel.AutoSize = true;
            this.TimerTimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimerTimeLabel.Location = new System.Drawing.Point(288, 168);
            this.TimerTimeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TimerTimeLabel.Name = "TimerTimeLabel";
            this.TimerTimeLabel.Size = new System.Drawing.Size(178, 42);
            this.TimerTimeLabel.TabIndex = 2;
            this.TimerTimeLabel.Text = "hh:mm:ss";
            // 
            // StartWorkButton
            // 
            this.StartWorkButton.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartWorkButton.Location = new System.Drawing.Point(93, 274);
            this.StartWorkButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.StartWorkButton.Name = "StartWorkButton";
            this.StartWorkButton.Size = new System.Drawing.Size(258, 104);
            this.StartWorkButton.TabIndex = 3;
            this.StartWorkButton.Text = "出勤";
            this.StartWorkButton.UseVisualStyleBackColor = true;
            // 
            // FinishWorkButton
            // 
            this.FinishWorkButton.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FinishWorkButton.Location = new System.Drawing.Point(440, 274);
            this.FinishWorkButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.FinishWorkButton.Name = "FinishWorkButton";
            this.FinishWorkButton.Size = new System.Drawing.Size(258, 104);
            this.FinishWorkButton.TabIndex = 4;
            this.FinishWorkButton.Text = "退勤";
            this.FinishWorkButton.UseVisualStyleBackColor = true;
            // 
            // Lasted20Label
            // 
            this.Lasted20Label.AutoSize = true;
            this.Lasted20Label.Location = new System.Drawing.Point(26, 436);
            this.Lasted20Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Lasted20Label.Name = "Lasted20Label";
            this.Lasted20Label.Size = new System.Drawing.Size(174, 24);
            this.Lasted20Label.TabIndex = 5;
            this.Lasted20Label.Text = "最近20件の登録";
            // 
            // Lasted20DataGridView
            // 
            this.Lasted20DataGridView.AllowUserToAddRows = false;
            this.Lasted20DataGridView.AllowUserToDeleteRows = false;
            this.Lasted20DataGridView.AllowUserToResizeColumns = false;
            this.Lasted20DataGridView.AllowUserToResizeRows = false;
            this.Lasted20DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lasted20DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordDate,
            this.RoundRecordDate,
            this.ToWork});
            this.Lasted20DataGridView.Location = new System.Drawing.Point(26, 472);
            this.Lasted20DataGridView.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Lasted20DataGridView.MultiSelect = false;
            this.Lasted20DataGridView.Name = "Lasted20DataGridView";
            this.Lasted20DataGridView.ReadOnly = true;
            this.Lasted20DataGridView.RowHeadersVisible = false;
            this.Lasted20DataGridView.RowHeadersWidth = 82;
            this.Lasted20DataGridView.RowTemplate.Height = 21;
            this.Lasted20DataGridView.Size = new System.Drawing.Size(748, 396);
            this.Lasted20DataGridView.TabIndex = 6;
            // 
            // RecordDate
            // 
            this.RecordDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RecordDate.DataPropertyName = "RecordDate";
            this.RecordDate.HeaderText = "登録日時";
            this.RecordDate.MinimumWidth = 10;
            this.RecordDate.Name = "RecordDate";
            this.RecordDate.ReadOnly = true;
            this.RecordDate.Width = 151;
            // 
            // RoundRecordDate
            // 
            this.RoundRecordDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RoundRecordDate.DataPropertyName = "RoundRecordDate";
            this.RoundRecordDate.HeaderText = "丸め日時";
            this.RoundRecordDate.MinimumWidth = 10;
            this.RoundRecordDate.Name = "RoundRecordDate";
            this.RoundRecordDate.ReadOnly = true;
            this.RoundRecordDate.Width = 147;
            // 
            // ToWork
            // 
            this.ToWork.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ToWork.DataPropertyName = "ToWork";
            this.ToWork.HeaderText = "出勤/退勤";
            this.ToWork.MinimumWidth = 10;
            this.ToWork.Name = "ToWork";
            this.ToWork.ReadOnly = true;
            this.ToWork.Width = 163;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.MainMenuStrip.Size = new System.Drawing.Size(800, 46);
            this.MainMenuStrip.TabIndex = 7;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.SettingsToolStripMenuItem,
            this.ExportToolStripMenuItem,
            this.toolStripSeparator1});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(103, 38);
            this.FileToolStripMenuItem.Text = "ファイル";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(356, 6);
            // 
            // ExportToolStripMenuItem
            // 
            this.ExportToolStripMenuItem.Enabled = false;
            this.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            this.ExportToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.ExportToolStripMenuItem.Text = "エクスポート(開発中)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Enabled = false;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.SettingsToolStripMenuItem.Text = "設定(開発中)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 892);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.Lasted20DataGridView);
            this.Controls.Add(this.Lasted20Label);
            this.Controls.Add(this.FinishWorkButton);
            this.Controls.Add(this.StartWorkButton);
            this.Controls.Add(this.TimerTimeLabel);
            this.Controls.Add(this.TimerDayLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Lasted20DataGridView)).EndInit();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerDayLabel;
        private System.Windows.Forms.Label TimerTimeLabel;
        private System.Windows.Forms.Button StartWorkButton;
        private System.Windows.Forms.Button FinishWorkButton;
        private System.Windows.Forms.Label Lasted20Label;
        private System.Windows.Forms.DataGridView Lasted20DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoundRecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToWork;
        private System.Windows.Forms.Timer CountTimer;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

