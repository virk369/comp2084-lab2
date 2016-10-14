using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// reference the model binding library
using System.Web.ModelBinding;

namespace Lesson6_COMP2084
{
    public partial class student_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveStudent_Click(object sender, EventArgs e)
        {
            // connect
            var conn = new ContosoEntities();

            // use the department class to create a new object
            Student s = new Student();

            // fill the properties of the new department object
            s.LastName = txtLastName.Text;
            s.FirstMidName = txtFirstMidName.Text;
            s.EnrollmentDate = Convert.ToDateTime(txtEnrollmentDate.Text);


            // save the new object
            conn.Students.Add(s);
            conn.SaveChanges();

            // redirect
            Response.Redirect("students.aspx");
        }
    }
}