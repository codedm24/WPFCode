﻿namespace SampleQuoteServerService
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.demoQuoteServiceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            this.demoQuoteServiceInstaller1 = new System.ServiceProcess.ServiceInstaller();
            // 
            // demoQuoteServiceProcessInstaller1
            // 
            this.demoQuoteServiceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.demoQuoteServiceProcessInstaller1.Password = null;
            this.demoQuoteServiceProcessInstaller1.Username = null;
            // 
            // demoQuoteServiceInstaller1
            // 
            this.demoQuoteServiceInstaller1.DisplayName = "DemoQuoteServerService";
            this.demoQuoteServiceInstaller1.ServiceName = "SampleQuoteService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.demoQuoteServiceProcessInstaller1,
            this.demoQuoteServiceInstaller1});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller demoQuoteServiceProcessInstaller1;
        private System.ServiceProcess.ServiceInstaller demoQuoteServiceInstaller1;
    }
}