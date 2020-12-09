﻿using System.Windows.Forms;

namespace KKManager.Windows.Content
{
    sealed partial class SideloaderModsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideloaderModsWindow));
            this.objectListView1 = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnEnabled = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnVersion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAuthor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnGuid = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnFilename = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnWebsite = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEnable = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDisable = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOpenModsDir = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            resources.ApplyResources(this.objectListView1, "objectListView1");
            this.objectListView1.AllColumns.Add(this.olvColumnEnabled);
            this.objectListView1.AllColumns.Add(this.olvColumnName);
            this.objectListView1.AllColumns.Add(this.olvColumnVersion);
            this.objectListView1.AllColumns.Add(this.olvColumnAuthor);
            this.objectListView1.AllColumns.Add(this.olvColumnGuid);
            this.objectListView1.AllColumns.Add(this.olvColumnFilename);
            this.objectListView1.AllColumns.Add(this.olvColumnWebsite);
            this.objectListView1.AllowColumnReorder = true;
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnEnabled,
            this.olvColumnName,
            this.olvColumnVersion,
            this.olvColumnAuthor,
            this.olvColumnGuid,
            this.olvColumnFilename,
            this.olvColumnWebsite});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.GridLines = true;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.OverlayText.Text = resources.GetString("resource.Text");
            this.objectListView1.ShowGroups = false;
            this.objectListView1.ShowItemToolTips = true;
            this.objectListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseHyperlinks = true;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.VirtualMode = true;
            this.objectListView1.SelectedIndexChanged += new System.EventHandler(this.objectListView1_SelectedIndexChanged);
            // 
            // olvColumnEnabled
            // 
            this.olvColumnEnabled.AspectName = "Enabled";
            this.olvColumnEnabled.CheckBoxes = true;
            resources.ApplyResources(this.olvColumnEnabled, "olvColumnEnabled");
            this.olvColumnEnabled.MaximumWidth = 23;
            this.olvColumnEnabled.MinimumWidth = 23;
            this.olvColumnEnabled.Searchable = false;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            resources.ApplyResources(this.olvColumnName, "olvColumnName");
            this.olvColumnName.MinimumWidth = 100;
            // 
            // olvColumnVersion
            // 
            this.olvColumnVersion.AspectName = "Version";
            resources.ApplyResources(this.olvColumnVersion, "olvColumnVersion");
            this.olvColumnVersion.MinimumWidth = 50;
            // 
            // olvColumnAuthor
            // 
            this.olvColumnAuthor.AspectName = "Author";
            resources.ApplyResources(this.olvColumnAuthor, "olvColumnAuthor");
            this.olvColumnAuthor.MinimumWidth = 50;
            // 
            // olvColumnGuid
            // 
            this.olvColumnGuid.AspectName = "Guid";
            resources.ApplyResources(this.olvColumnGuid, "olvColumnGuid");
            this.olvColumnGuid.MinimumWidth = 50;
            // 
            // olvColumnFilename
            // 
            this.olvColumnFilename.AspectName = "FileName";
            resources.ApplyResources(this.olvColumnFilename, "olvColumnFilename");
            this.olvColumnFilename.MinimumWidth = 50;
            // 
            // olvColumnWebsite
            // 
            this.olvColumnWebsite.AspectName = "Website";
            resources.ApplyResources(this.olvColumnWebsite, "olvColumnWebsite");
            this.olvColumnWebsite.Hyperlink = true;
            this.olvColumnWebsite.MinimumWidth = 100;
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButtonEnable,
            this.toolStripButtonDisable,
            this.toolStripSeparator2,
            this.toolStripButtonDelete,
            this.toolStripSeparator3,
            this.toolStripButtonOpenModsDir,
            this.toolStripTextBoxSearch});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripButtonEnable
            // 
            resources.ApplyResources(this.toolStripButtonEnable, "toolStripButtonEnable");
            this.toolStripButtonEnable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEnable.Name = "toolStripButtonEnable";
            this.toolStripButtonEnable.Click += new System.EventHandler(this.toolStripButtonEnable_Click);
            // 
            // toolStripButtonDisable
            // 
            resources.ApplyResources(this.toolStripButtonDisable, "toolStripButtonDisable");
            this.toolStripButtonDisable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDisable.Name = "toolStripButtonDisable";
            this.toolStripButtonDisable.Click += new System.EventHandler(this.toolStripButtonDisable_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripButtonDelete
            // 
            resources.ApplyResources(this.toolStripButtonDelete, "toolStripButtonDelete");
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolStripButtonOpenModsDir
            // 
            resources.ApplyResources(this.toolStripButtonOpenModsDir, "toolStripButtonOpenModsDir");
            this.toolStripButtonOpenModsDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOpenModsDir.Name = "toolStripButtonOpenModsDir";
            this.toolStripButtonOpenModsDir.Click += new System.EventHandler(this.toolStripButtonOpenModsDir_Click);
            // 
            // toolStripTextBoxSearch
            // 
            resources.ApplyResources(this.toolStripTextBoxSearch, "toolStripTextBoxSearch");
            this.toolStripTextBoxSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            // 
            // SideloaderModsWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SideloaderModsWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SideloaderModsWindow_FormClosed);
            this.Shown += new System.EventHandler(this.SideloaderModsWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BrightIdeasSoftware.FastObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumnVersion;
        private BrightIdeasSoftware.OLVColumn olvColumnAuthor;
        private BrightIdeasSoftware.OLVColumn olvColumnGuid;
        private BrightIdeasSoftware.OLVColumn olvColumnWebsite;
        private BrightIdeasSoftware.OLVColumn olvColumnFilename;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonEnable;
        private System.Windows.Forms.ToolStripButton toolStripButtonDisable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private BrightIdeasSoftware.OLVColumn olvColumnEnabled;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenModsDir;
        private ToolStripTextBox toolStripTextBoxSearch;
    }
}