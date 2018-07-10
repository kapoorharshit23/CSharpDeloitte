using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace BulkEmail
{
    public partial class BulkEmail : Form
    {
        public String path;
        public List<String> FirstName = new List<string>();
        public List<String> LastName = new List<string>();
        public List<String> EmailList = new List<string>();
        public List<String> UsernamesList = new List<string>();
        public List<String> PasswordList = new List<string>();
        DataTable data = new DataTable();

        public BulkEmail()
        {
            InitializeComponent();
        }
        

        private void LoadData_Click(object sender, EventArgs e)
        {
            //TextBox pathBox = (TextBox)FilePath;

            ////String path = pathBox.ToString();
            //String path = pathBox.Text.ToString();
            //Console.WriteLine(path);
            //String name = "Sheet1";
            //String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            //            path +
            //            ";Extended Properties=\"Excel 12.0 XML;Readonly=False;HDR=YES;IMEX=1;\";";

            //Console.WriteLine(constr);

            //OleDbConnection con = new OleDbConnection(constr);
            //OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
            //con.Open();

            //OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            
            //sda.Fill(data);
            data.Columns.Add("First Name");
            data.Columns.Add("Last Name");
            data.Columns.Add("Email");
            data.Columns.Add("UserNames");
            data.Columns.Add("Password");
            //data.Rows.Add("aa", "bb", "cc", "dd", "ee");
            dataGrid.DataSource = data;

            

            /*for(int i=0;i<FirstName.Count;i++)
            {
                Console.WriteLine(FirstName[i].ToString() + LastName[i].ToString());
                OpenOutLook(EmailList[i]);
            }*/

            /*foreach(String eachRow in FirstName)
            {
                Console.WriteLine(FirstName.ToString() + LastName.ToString());
            }*/

            //TraversingData traversingData = new TraversingData();
            //traversingData.Traverse(data);
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //string fileToOpen = FD.FileName;
                //FilePath.Text = FD.FileName;
            }
        }

        public int OpenOutLook(String email,String fname,String lname,String uNameList,String pwdList)
        {
            try
            {
                // Create the Outlook application by using inline initialization.
                Outlook.Application oApp = new Outlook.Application();

                //Create the new message by using the simplest approach.
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);

                //Add a recipient.
                // TODO: Change the following recipient where appropriate.
                Outlook.Recipient oRecip = (Outlook.Recipient)oMsg.Recipients.Add(email);
                oRecip.Resolve();

                //Set the basic properties.
                if(Subject.Text==null)
                {
                    oMsg.Subject = "This is the subject of the test message";   //Default Subject
                }
                else
                {
                    oMsg.Subject = Subject.Text.ToString();
                }

                //Check if any template is selected
                if (EmailTemplate.CheckedItems.Count > 0)
                {
                    Console.WriteLine("Checked");
                    if(EmailTemplate.CheckedItems.Contains("Usernames"))
                    {
                        oMsg.Subject = "Workday SIT Tenant Username";
                        oMsg.Body = "The following username will allow you to login to the Workday SIT tenant. A password will be sent shortly.\nUsername: "+uNameList+"\nTenant URL: https://wd3-impl.workday.com/transurban5/d/home.htmld\n\nIf you have any trouble logging in, please reply to this email.";
                    }
                    else
                    {
                        if (EmailTemplate.CheckedItems.Contains("Passwords"))
                        {
                            oMsg.Subject = "Workday SIT Tenant Password";
                            oMsg.Body = "Password: "+ pwdList + "\n\nPlease refer to the previous email for your username.\nIf you wish to change your password after logging in, please visit the Change Password page.";
                        }
                    }
                }
                else
                {
                    if (EmailContent.Text == null)
                    {
                        oMsg.Body = "This is the text in the message.";   //Default Email COntent
                    }
                    else
                    {
                        oMsg.Body = DecipherEmailCOntent(EmailContent.Text.ToString(), fname, lname, uNameList, pwdList);

                        //oMsg.Body = EmailContent.Text.ToString();
                    }
                }


                //Add an attachment.
                // TODO: change file path where appropriate
                //String sSource = "C:\\setupxlg.txt";
                //String sDisplayName = "MyFirstAttachment";
                //int iPosition = (int)oMsg.Body.Length + 1;
                //int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                //Outlook.Attachment oAttach = oMsg.Attachments.Add(sSource, iAttachType, iPosition, sDisplayName);

                if (ActionToDo.CheckedItems.Count > 0)
                {
                    Console.WriteLine("ActionTODO");
                    if (ActionToDo.CheckedItems.Contains("Send"))
                    {

                        Console.WriteLine("Send");
                        //oMsg.Display(true);  //modal

                        //Send the message.
                        oMsg.Save();
                        oMsg.Send();
                    }
                    else
                    {
                        Console.WriteLine("ActionTODO ELSE");
                        if (ActionToDo.CheckedItems.Contains("Preview"))
                        {
                            oMsg.Display(true);  //modal

                            Console.WriteLine("Preview");
                            //Send the message.
                            oMsg.Save();
                            //oMsg.Send();
                        }
                    }
                }
                else
                {
                    //Display Dialog box with an error
                    MessageBox.Show("Please select one of the actions.");
                }

                /*// If you want to, display the message.
                oMsg.Display(true);  //modal

                //Send the message.
                oMsg.Save();
                //oMsg.Send();

                //Explicitly release objects.
                oRecip = null;
                //oAttach = null;
                oMsg = null;
                oApp = null;*/
            }
            catch (Exception e)
            {

            }
            return 0;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            for(int i=0;i<FirstName.Count;i++)
            {
                Console.WriteLine(FirstName[i].ToString() + LastName[i].ToString());
                OpenOutLook(EmailList[i],FirstName[i],LastName[i],UsernamesList[i],PasswordList[i]);
            }
        }
        public String DecipherEmailCOntent(String emailCont,String firstN,String lastN,String userNList,String passwordList)
        {
            String fNameReplacedEmailCont;
            String lNameReplacedEmailCont;
            String usernameReplacedEmailCont;
            String passwordReplacedEmailCont;
            fNameReplacedEmailCont = emailCont.Replace("%FNAME%",firstN);
            //Console.WriteLine(fNameReplacedEmailCont);
            //lNameReplacedEmailCont = fNameReplacedEmailCont;
            lNameReplacedEmailCont = fNameReplacedEmailCont.Replace("%LNAME%", lastN);
            //Console.WriteLine(lNameReplacedEmailCont);
            //usernameReplacedEmailCont = lNameReplacedEmailCont;
            usernameReplacedEmailCont = lNameReplacedEmailCont.Replace("%USERNAME%", userNList);
            //Console.WriteLine(usernameReplacedEmailCont);
            //passwordReplacedEmailCont = usernameReplacedEmailCont;
            passwordReplacedEmailCont = usernameReplacedEmailCont.Replace("%PASSWORD%", passwordList);
            //Console.WriteLine(passwordReplacedEmailCont);

            return passwordReplacedEmailCont;
        }

        private void EmailTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in data.Rows)
            {
                FirstName.Add(row["First Name"].ToString());
                LastName.Add(row["Last Name"].ToString());
                EmailList.Add(row["Email"].ToString());
                UsernamesList.Add(row["Usernames"].ToString());
                PasswordList.Add(row["Password"].ToString());
            }
        }
    }
}
