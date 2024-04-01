using System.Text.Json;
using System.Text.RegularExpressions;
using Questionnaire__WinForms.Models;

namespace Questionnaire__WinForms;

public partial class Questionnaire : Form
{
    public Questionnaire()
    {
        InitializeComponent();
    }

    public List<User> users = new();
    public User _user;
    private void txtBoxName_TextChanged(object sender, EventArgs e)
    {
        Regex regex = new("^[a-zA-Z]{3,30}$");
        if (regex.IsMatch(txtBoxName.Text))
            txtBoxName.ForeColor = Color.Green;
        else txtBoxName.ForeColor = Color.Red;
    }

    private void txtBoxSurname_TextChanged(object sender, EventArgs e)
    {
        Regex regex = new("^[a-zA-Z]{4,30}$");
        if (regex.IsMatch(txtBoxSurname.Text))
            txtBoxSurname.ForeColor = Color.Green;
        else txtBoxSurname.ForeColor = Color.Red;
    }

    private void txtBoxEmail_TextChanged(object sender, EventArgs e)
    {
        Regex regex = new("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
        if (regex.IsMatch(txtBoxEmail.Text))
            txtBoxEmail.ForeColor = Color.Green;
        else txtBoxEmail.ForeColor = Color.Red;
    }

    private void txtBoxPhone_TextChanged(object sender, EventArgs e)
    {
        Regex regex = new("^(?:\\+994|050|051|055|070|077|099|010)\\d{7}$");
        if (regex.IsMatch(txtBoxPhone.Text))
            txtBoxPhone.ForeColor = Color.Green;
        else txtBoxPhone.ForeColor = Color.Red;
    }

    private void listBoxUsers_Load(object sender, EventArgs e)
    {
        listBoxUsers.HorizontalScrollbar = true;
        listBoxUsers.Items.AddRange(users.ToArray());
    }

    private void btnAppendandChange_Click(object sender, EventArgs e)
    {
        if (btnSaveAndUpdate.BackColor == Color.Lime)
        {
            _user = new()
            {
                Name = txtBoxName.Text,
                Surname = txtBoxSurname.Text,
                Email = txtBoxEmail.Text,
                PhoneNumber = txtBoxPhone.Text,
                Brithday = dateTimeBrithday.Text
            };

            users.Add(_user);
            listBoxUsers.Items.Add(_user);
        }
        if (btnSaveAndUpdate.BackColor == Color.DodgerBlue) 
        {
            if (listBoxUsers.SelectedIndex != -1)
            {
                User? selectedUser = (User)listBoxUsers.SelectedItem;
                selectedUser.Name = txtBoxName.Text;
                selectedUser.Surname = txtBoxSurname.Text;
                selectedUser.Email = txtBoxEmail.Text;
                selectedUser.PhoneNumber = txtBoxPhone.Text;
                selectedUser.Brithday = dateTimeBrithday.Text;
                listBoxUsers.Items[listBoxUsers.SelectedIndex] = selectedUser;
                listBoxUsers.ClearSelected();
                btnCleartxtBoxes_Click(sender, e);
                btnSaveAndUpdate.BackColor = Color.Lime;
                btnSaveAndUpdate.Text = "Append";
            }

        }

    }
    private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBoxUsers.SelectedIndex != -1)
        {
            btnSaveAndUpdate.BackColor = Color.DodgerBlue;
            btnSaveAndUpdate.Text = "Uptade";
            User? selectedUser = (User)listBoxUsers.SelectedItem;
            txtBoxName.Text = selectedUser?.Name;
            txtBoxSurname.Text = selectedUser?.Surname;
            txtBoxEmail.Text = selectedUser?.Email;
            txtBoxPhone.Text = selectedUser?.PhoneNumber;
            dateTimeBrithday.Text = selectedUser?.Brithday;
            
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        string fileName = $"{txtBoxFileName.Text}.json";
        if (File.Exists(fileName))
        {
            users.Clear();
            foreach (var item in listBoxUsers.Items) 
                users.Add((User)item);    
            var jsonSerilaze = JsonSerializer.Serialize(users);
            File.WriteAllText(fileName, jsonSerilaze);
        }
        else
        {
            var jsonSerilaze = JsonSerializer.Serialize(users);
            File.WriteAllText(fileName, jsonSerilaze);
        }
        btnClearListBox_Click(sender, e);
        btnCleartxtBoxes_Click(sender, e);
        MessageBox.Show($"User Save in {fileName}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        string fileName = $"{txtBoxFileName.Text}.json";
        if (File.Exists(fileName))
        {
            var json = File.ReadAllText(fileName);
            List<User> users = JsonSerializer.Deserialize<List<User>>(json) ?? new();
            listBoxUsers.Items.Clear();
            foreach (var item in users) listBoxUsers.Items.Add(item);

        }
        else
            MessageBox.Show("Not Found File", "Eror Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

    }

    private void btnClearListBox_Click(object sender, EventArgs e)
    {
        listBoxUsers.Items.Clear();
        txtBoxFileName.Text = null;
    }

    private void btnCleartxtBoxes_Click(object sender, EventArgs e)
    {
        txtBoxName.Text = null;
        txtBoxSurname.Text = null;
        txtBoxPhone.Text = null;
        txtBoxEmail.Text = null;
        dateTimeBrithday.Text = null;
    }
}
