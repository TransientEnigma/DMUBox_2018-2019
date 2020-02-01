namespace DMUBox
{
    partial class frmFindStudent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label studentNoLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label familyNameLabel;
            System.Windows.Forms.Label hallNoLabel;
            System.Windows.Forms.Label apartmentNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindStudent));
            System.Windows.Forms.Label forenameLabel;
            this.dMUBoxDataSet = new DMUBox.DMUBoxDataSet();
            this.sproc_tblStudent_FilterByStudentNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sproc_tblStudent_FilterByStudentNoTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.sproc_tblStudent_FilterByStudentNoTableAdapter();
            this.tableAdapterManager = new DMUBox.DMUBoxDataSetTableAdapters.TableAdapterManager();
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.studentNoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studentNoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.studentNoTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.familyNameTextBox = new System.Windows.Forms.TextBox();
            this.hallNoTextBox = new System.Windows.Forms.TextBox();
            this.apartmentNoTextBox = new System.Windows.Forms.TextBox();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.forenameTextBox = new System.Windows.Forms.TextBox();
            studentNoLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            familyNameLabel = new System.Windows.Forms.Label();
            hallNoLabel = new System.Windows.Forms.Label();
            apartmentNoLabel = new System.Windows.Forms.Label();
            forenameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_tblStudent_FilterByStudentNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_tblStudent_FilterByStudentNoBindingNavigator)).BeginInit();
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentNoLabel
            // 
            studentNoLabel.AutoSize = true;
            studentNoLabel.Location = new System.Drawing.Point(111, 66);
            studentNoLabel.Name = "studentNoLabel";
            studentNoLabel.Size = new System.Drawing.Size(64, 13);
            studentNoLabel.TabIndex = 2;
            studentNoLabel.Text = "Student No:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(145, 92);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Title:";
            // 
            // familyNameLabel
            // 
            familyNameLabel.AutoSize = true;
            familyNameLabel.Location = new System.Drawing.Point(105, 144);
            familyNameLabel.Name = "familyNameLabel";
            familyNameLabel.Size = new System.Drawing.Size(70, 13);
            familyNameLabel.TabIndex = 8;
            familyNameLabel.Text = "Family Name:";
            // 
            // hallNoLabel
            // 
            hallNoLabel.AutoSize = true;
            hallNoLabel.Location = new System.Drawing.Point(130, 170);
            hallNoLabel.Name = "hallNoLabel";
            hallNoLabel.Size = new System.Drawing.Size(45, 13);
            hallNoLabel.TabIndex = 10;
            hallNoLabel.Text = "Hall No:";
            // 
            // apartmentNoLabel
            // 
            apartmentNoLabel.AutoSize = true;
            apartmentNoLabel.Location = new System.Drawing.Point(100, 196);
            apartmentNoLabel.Name = "apartmentNoLabel";
            apartmentNoLabel.Size = new System.Drawing.Size(75, 13);
            apartmentNoLabel.TabIndex = 12;
            apartmentNoLabel.Text = "Apartment No:";
            // 
            // dMUBoxDataSet
            // 
            this.dMUBoxDataSet.DataSetName = "DMUBoxDataSet";
            this.dMUBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sproc_tblStudent_FilterByStudentNoBindingSource
            // 
            this.sproc_tblStudent_FilterByStudentNoBindingSource.DataMember = "sproc_tblStudent_FilterByStudentNo";
            this.sproc_tblStudent_FilterByStudentNoBindingSource.DataSource = this.dMUBoxDataSet;
            // 
            // sproc_tblStudent_FilterByStudentNoTableAdapter
            // 
            this.sproc_tblStudent_FilterByStudentNoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tblBoxTableAdapter = null;
            this.tableAdapterManager.tblHallTableAdapter = null;
            this.tableAdapterManager.tblOrderLineTableAdapter = null;
            this.tableAdapterManager.tblOrderTableAdapter = null;
            this.tableAdapterManager.tblStudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DMUBox.DMUBoxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sproc_tblStudent_FilterByStudentNoBindingNavigator
            // 
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.BindingSource = this.sproc_tblStudent_FilterByStudentNoBindingSource;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem});
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.Name = "sproc_tblStudent_FilterByStudentNoBindingNavigator";
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.Size = new System.Drawing.Size(456, 25);
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.TabIndex = 0;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem
            // 
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.Enabled = false;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.Image")));
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.Name = "sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem";
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentNoToolStripLabel,
            this.studentNoToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(77, 35);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(254, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // studentNoToolStripLabel
            // 
            this.studentNoToolStripLabel.Name = "studentNoToolStripLabel";
            this.studentNoToolStripLabel.Size = new System.Drawing.Size(94, 22);
            this.studentNoToolStripLabel.Text = "Enter P-number:";
            // 
            // studentNoToolStripTextBox
            // 
            this.studentNoToolStripTextBox.Name = "studentNoToolStripTextBox";
            this.studentNoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillToolStripButton.Text = "Search";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // studentNoTextBox
            // 
            this.studentNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sproc_tblStudent_FilterByStudentNoBindingSource, "StudentNo", true));
            this.studentNoTextBox.Location = new System.Drawing.Point(181, 63);
            this.studentNoTextBox.Name = "studentNoTextBox";
            this.studentNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNoTextBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sproc_tblStudent_FilterByStudentNoBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(181, 89);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 5;
            // 
            // familyNameTextBox
            // 
            this.familyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sproc_tblStudent_FilterByStudentNoBindingSource, "FamilyName", true));
            this.familyNameTextBox.Location = new System.Drawing.Point(181, 141);
            this.familyNameTextBox.Name = "familyNameTextBox";
            this.familyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.familyNameTextBox.TabIndex = 9;
            // 
            // hallNoTextBox
            // 
            this.hallNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sproc_tblStudent_FilterByStudentNoBindingSource, "HallNo", true));
            this.hallNoTextBox.Location = new System.Drawing.Point(181, 167);
            this.hallNoTextBox.Name = "hallNoTextBox";
            this.hallNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.hallNoTextBox.TabIndex = 11;
            // 
            // apartmentNoTextBox
            // 
            this.apartmentNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sproc_tblStudent_FilterByStudentNoBindingSource, "ApartmentNo", true));
            this.apartmentNoTextBox.Location = new System.Drawing.Point(181, 193);
            this.apartmentNoTextBox.Name = "apartmentNoTextBox";
            this.apartmentNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apartmentNoTextBox.TabIndex = 13;
            // 
            // btnClose2
            // 
            this.btnClose2.Location = new System.Drawing.Point(361, 302);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(75, 23);
            this.btnClose2.TabIndex = 14;
            this.btnClose2.Text = "Close";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // forenameLabel
            // 
            forenameLabel.AutoSize = true;
            forenameLabel.Location = new System.Drawing.Point(118, 118);
            forenameLabel.Name = "forenameLabel";
            forenameLabel.Size = new System.Drawing.Size(57, 13);
            forenameLabel.TabIndex = 14;
            forenameLabel.Text = "Forename:";
            // 
            // forenameTextBox
            // 
            this.forenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sproc_tblStudent_FilterByStudentNoBindingSource, "Forename", true));
            this.forenameTextBox.Location = new System.Drawing.Point(181, 115);
            this.forenameTextBox.Name = "forenameTextBox";
            this.forenameTextBox.Size = new System.Drawing.Size(100, 20);
            this.forenameTextBox.TabIndex = 15;
            // 
            // frmFindStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(456, 388);
            this.Controls.Add(forenameLabel);
            this.Controls.Add(this.forenameTextBox);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(apartmentNoLabel);
            this.Controls.Add(this.apartmentNoTextBox);
            this.Controls.Add(hallNoLabel);
            this.Controls.Add(this.hallNoTextBox);
            this.Controls.Add(familyNameLabel);
            this.Controls.Add(this.familyNameTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(studentNoLabel);
            this.Controls.Add(this.studentNoTextBox);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.sproc_tblStudent_FilterByStudentNoBindingNavigator);
            this.Name = "frmFindStudent";
            this.Text = "Find Student";
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_tblStudent_FilterByStudentNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_tblStudent_FilterByStudentNoBindingNavigator)).EndInit();
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.ResumeLayout(false);
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMUBoxDataSet dMUBoxDataSet;
        private System.Windows.Forms.BindingSource sproc_tblStudent_FilterByStudentNoBindingSource;
        private DMUBoxDataSetTableAdapters.sproc_tblStudent_FilterByStudentNoTableAdapter sproc_tblStudent_FilterByStudentNoTableAdapter;
        private DMUBoxDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sproc_tblStudent_FilterByStudentNoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel studentNoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox studentNoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.TextBox studentNoTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox familyNameTextBox;
        private System.Windows.Forms.TextBox hallNoTextBox;
        private System.Windows.Forms.TextBox apartmentNoTextBox;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.TextBox forenameTextBox;
    }
}