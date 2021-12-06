
namespace CrystalChroniclesArtiTracker
{
    partial class ArtiTracker
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
            this.DungeonBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DungeonBox
            // 
            this.DungeonBox.FormattingEnabled = true;
            this.DungeonBox.Location = new System.Drawing.Point(13, 13);
            this.DungeonBox.Name = "DungeonBox";
            this.DungeonBox.Size = new System.Drawing.Size(121, 23);
            this.DungeonBox.TabIndex = 0;
            this.DungeonBox.Text = "Select a Dungeon";
            this.DungeonBox.SelectedIndexChanged += new System.EventHandler(this.DungeonBox_SelectedIndexChanged);
            // 
            // ArtiTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DungeonBox);
            this.Name = "ArtiTracker";
            this.Text = "ArtiTracker";
            this.Load += new System.EventHandler(this.ArtiTracker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox DungeonBox;
    }
}

