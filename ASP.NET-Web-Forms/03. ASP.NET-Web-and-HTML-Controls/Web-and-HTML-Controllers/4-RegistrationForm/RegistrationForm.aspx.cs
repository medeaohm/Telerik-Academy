namespace RegistrationForm
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            this.PanelStudent.Controls.Add(new LiteralControl("<h3>Registered student: </h3>"));
            this.PanelStudent.Controls.Add(new LiteralControl(this.Label1.Text + ": " + this.TextBoxFirstName.Text));
            this.PanelStudent.Controls.Add(new LiteralControl("<br />"));
            this.PanelStudent.Controls.Add(new LiteralControl(this.Label2.Text + ": " + this.TextBoxLastName.Text));
            this.PanelStudent.Controls.Add(new LiteralControl("<br />"));
            this.PanelStudent.Controls.Add(new LiteralControl(this.Label3.Text + ": " + this.TextBoxFacultyNumber.Text));
            this.PanelStudent.Controls.Add(new LiteralControl("<br />"));
            this.PanelStudent.Controls.Add(new LiteralControl(this.Label4.Text + ": " + this.DropDownListUniversities.SelectedValue));
            this.PanelStudent.Controls.Add(new LiteralControl("<br />"));
            this.PanelStudent.Controls.Add(new LiteralControl(this.Label5.Text + ": " + this.DropDownListSpecialties.SelectedValue));
            this.PanelStudent.Controls.Add(new LiteralControl("<br />"));
            this.PanelStudent.Controls.Add(new LiteralControl(this.Label6.Text + ": "));
            foreach (ListItem item in ListBoxCourses.Items)
            {
                if (item.Selected)
                {
                    this.PanelStudent.Controls.Add(new LiteralControl(item.Value + ", "));
                }
            }
            this.PanelStudent.Controls.Add(new LiteralControl("<br />"));
        }
    }
}