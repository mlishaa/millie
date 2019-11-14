using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class Form1 : Form
    {
        List<Contact> myContactList=new List<Contact>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addContact(Contact contact)
        {
            myContactList.Add(contact);

        }

        private void writeToFile(Contact contact)
        {
            using(StreamWriter sw=new StreamWriter("Contacts.txt",true))
            {
                sw.WriteLine(contact.ToString());
            }

        }
        public void readFromFile()
        {

            using (StreamReader sr = new StreamReader("Contacts.txt"))
            {
                String[] lines = File.ReadAllLines("Contacts.txt");
                foreach (var line in lines)
                {
                    String[] words = new String[3];
                    words=Regex.Split(line,"\t");
                    myContactList.Add(new Contact(words[0], words[1], words[2]));
                   
                }
                 
                   
                }


            }
        

        public void display()
        {
            ContactsListBox.Items.Clear();
            
            
            for(int i = 0; i < myContactList.Count; ++i)
            {
                ContactsListBox.Items.Add(myContactList[i]);
            }
        }


        private void btnAddContact_Click(object sender, EventArgs e)
        {

            Regex re = new Regex(@"\d{3}-\d{3}-\d{4}");
            Contact contact = new Contact();
            contact.FirstName = fName.Text;
            contact.LastName = lName.Text;
            if (re.IsMatch(pNumber.Text))
            {
                contact.Phone = pNumber.Text;
            }
            else
            {
                pNumber.Text = "";
                MessageBox.Show("invalid phone number");
            }
            
            if((fName.Text.Trim() !="") && (lName.Text.Trim() !="") &&(pNumber.Text.Trim() !=""))
            {
                contact.FirstName= fName.Text;
                contact.LastName= lName.Text;
                contact.Phone = pNumber.Text;
                myContactList.Add(contact);
                writeToFile(contact);
                display();
                clearAll();

               }
           
        }
        private void clearAll()
        {
            fName.Text = String.Empty;
            lName.Text=String.Empty;
            pNumber.Text=String.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readFromFile();
            display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           String theOne=  ContactsListBox.SelectedItem.ToString();
            String line;
            string tempFile = Path.GetTempFileName();
            using (var sw = new StreamWriter(tempFile))
            using (StreamReader sr = new StreamReader("Contacts.txt"))
                while ((line = sr.ReadLine()) != null)
                {
                    if (!theOne.Contains(line))
                        sw.WriteLine(line);
                }

            File.Delete("Contacts.txt");
            File.Move(tempFile, "Contacts.txt");
            myContactList.Clear();
            readFromFile();
            display();
            
           
        }
    }
}
