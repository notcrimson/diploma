using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
    public partial class LogoutMessage : Form
    {
        public LogoutMessage()
        {
            InitializeComponent();
        }

        private void LogoutMessage_Load(object sender, EventArgs e)
        {
            if (basicForm.previousForm.Name == "Login")
            {
                LogoutButton.Visible = false;
                ExitButton.Location = new Point(113, 109);
                TheCancelButton.Location = new Point(248, 109);
            }
        }


        private void TheCancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            checkUser(closeAllForms);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            checkUser(Application.Exit);
        }
        private void closeAllForms()
        {
            List<Form> openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (var f in openForms)
            {
                if (f.Name != "Login")
                {
                    f.Dispose();
                    f.Close();
                }
            }
            openForms[0].Show();
        }
        private void checkUser(Action func)
        {
            using (Model1 db = new Model1())
            {
                if (basicForm.USER is null)
                {
                    func();
                }
                else
                {
                    User_Log existingLog = db.User_Log.Where(x => x.UserID == basicForm.USER.UserId).FirstOrDefault();
                    User_Log log = new User_Log();
                    if (basicForm.previousForm.Name != "Login")
                    {
                        if (existingLog == null)
                        {
                            log.UserID = basicForm.USER.UserId;
                            log.LastFormUsed = basicForm.previousForm.Name;
                            db.User_Log.Add(log);
                        }
                        else
                        {
                            existingLog.LastFormUsed = basicForm.previousForm.Name;
                        }

                        try
                        {
                            db.SaveChanges();
                            Properties.Settings.Default.selectedPu = basicForm.selectedPU;
                            Properties.Settings.Default.testName = basicForm.testName;
                            Properties.Settings.Default.Save();
                        }
                        catch (System.Data.Entity.Validation.DbEntityValidationException f)
                        {
                            foreach (var eve in f.EntityValidationErrors)
                            {
                                Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                    eve.Entry.Entity.GetType().Name, eve.Entry.State);
                                foreach (var ve in eve.ValidationErrors)
                                {
                                    Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                        ve.PropertyName, ve.ErrorMessage);
                                }
                            }
                        }
                        func();
                    }

                    Dispose();
                    GC.Collect();
                }
            }
        }
    }
}
