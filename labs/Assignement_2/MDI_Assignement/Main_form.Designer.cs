namespace MDI_Assignement
{
    partial class Main_form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientManagemementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAppointmentByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAPatientsAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementSystemToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementSystemToolStripMenuItem
            // 
            this.managementSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorManagementToolStripMenuItem,
            this.patientManagemementToolStripMenuItem,
            this.appointmentManagementToolStripMenuItem});
            this.managementSystemToolStripMenuItem.Name = "managementSystemToolStripMenuItem";
            this.managementSystemToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.managementSystemToolStripMenuItem.Text = "Management System";
            this.managementSystemToolStripMenuItem.Click += new System.EventHandler(this.managementSystemToolStripMenuItem_Click);
            // 
            // doctorManagementToolStripMenuItem
            // 
            this.doctorManagementToolStripMenuItem.Name = "doctorManagementToolStripMenuItem";
            this.doctorManagementToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.doctorManagementToolStripMenuItem.Text = "Doctor Management ";
            this.doctorManagementToolStripMenuItem.Click += new System.EventHandler(this.doctorManagementToolStripMenuItem_Click);
            // 
            // patientManagemementToolStripMenuItem
            // 
            this.patientManagemementToolStripMenuItem.Name = "patientManagemementToolStripMenuItem";
            this.patientManagemementToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.patientManagemementToolStripMenuItem.Text = "Patient Managemement";
            this.patientManagemementToolStripMenuItem.Click += new System.EventHandler(this.patientManagemementToolStripMenuItem_Click);
            // 
            // appointmentManagementToolStripMenuItem
            // 
            this.appointmentManagementToolStripMenuItem.Name = "appointmentManagementToolStripMenuItem";
            this.appointmentManagementToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.appointmentManagementToolStripMenuItem.Text = "Appointment Management";
            this.appointmentManagementToolStripMenuItem.Click += new System.EventHandler(this.appointmentManagementToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.searchAppointmentByDateToolStripMenuItem,
            this.showAPatientsAppointmentsToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.showAllToolStripMenuItem.Text = "Show All ";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // searchAppointmentByDateToolStripMenuItem
            // 
            this.searchAppointmentByDateToolStripMenuItem.Name = "searchAppointmentByDateToolStripMenuItem";
            this.searchAppointmentByDateToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.searchAppointmentByDateToolStripMenuItem.Text = "Search appointment by date ";
            this.searchAppointmentByDateToolStripMenuItem.Click += new System.EventHandler(this.searchAppointmentByDateToolStripMenuItem_Click);
            // 
            // showAPatientsAppointmentsToolStripMenuItem
            // 
            this.showAPatientsAppointmentsToolStripMenuItem.Name = "showAPatientsAppointmentsToolStripMenuItem";
            this.showAPatientsAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.showAPatientsAppointmentsToolStripMenuItem.Text = "Show a patient\'s appointments";
            this.showAPatientsAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.showAPatientsAppointmentsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_form";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managementSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientManagemementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAppointmentByDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAPatientsAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

