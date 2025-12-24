namespace EmployeeInformationSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // lblName
            this.lblName.Text = "Name";
            this.lblName.Location = new System.Drawing.Point(30, 30);

            // lblDept
            this.lblDept.Text = "Department";
            this.lblDept.Location = new System.Drawing.Point(30, 70);

            // lblSalary
            this.lblSalary.Text = "Salary";
            this.lblSalary.Location = new System.Drawing.Point(30, 110);

            // txtName
            this.txtName.Location = new System.Drawing.Point(120, 30);
            this.txtName.Width = 200;

            // txtDept
            this.txtDept.Location = new System.Drawing.Point(120, 70);
            this.txtDept.Width = 200;

            // txtSalary
            this.txtSalary.Location = new System.Drawing.Point(120, 110);
            this.txtSalary.Width = 200;

            // btnAdd
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.Location = new System.Drawing.Point(120, 150);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(30, 200);
            this.dataGridView1.Size = new System.Drawing.Size(500, 200);

            // Form1
            this.Text = "Employee Information System";
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
