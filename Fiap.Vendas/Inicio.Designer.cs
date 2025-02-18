namespace Fiap.Vendas
{
    partial class Inicio
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
            menuStrip1 = new MenuStrip();
            createToolStripMenuItem = new ToolStripMenuItem();
            clientPFToolStripMenuItem = new ToolStripMenuItem();
            clientPJToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            finacialToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { createToolStripMenuItem, reportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientPFToolStripMenuItem, clientPJToolStripMenuItem });
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(53, 20);
            createToolStripMenuItem.Text = "Create";
            // 
            // clientPFToolStripMenuItem
            // 
            clientPFToolStripMenuItem.Name = "clientPFToolStripMenuItem";
            clientPFToolStripMenuItem.Size = new Size(180, 22);
            clientPFToolStripMenuItem.Text = "Client PF";
            // 
            // clientPJToolStripMenuItem
            // 
            clientPJToolStripMenuItem.Name = "clientPJToolStripMenuItem";
            clientPJToolStripMenuItem.Size = new Size(180, 22);
            clientPJToolStripMenuItem.Text = "Client PJ";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { finacialToolStripMenuItem });
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(54, 20);
            reportToolStripMenuItem.Text = "Report";
            // 
            // finacialToolStripMenuItem
            // 
            finacialToolStripMenuItem.Name = "finacialToolStripMenuItem";
            finacialToolStripMenuItem.Size = new Size(180, 22);
            finacialToolStripMenuItem.Text = "Finacial";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "Inicio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem clientPFToolStripMenuItem;
        private ToolStripMenuItem clientPJToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem finacialToolStripMenuItem;
    }
}