using System.CodeDom;
using System.ComponentModel;
using System.Data;

namespace ControlTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _categories = new BindingList<Category>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordTextbox.Text = "";
            passwordTextbox.PasswordChar = '*';
            categoriesDataGridView.Visible = false;
            passwordTextbox.MaxLength = 20;
            categoriesGroup.Visible = false;
            saveChangesButton.Visible = false;
            deleteCategoriesButton.Visible = false;
        }

        private BindingList<Category> _categories;
        private CategoryRepository _categoryRepository;

        
        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                var categoriesFromDatabase = _categoryRepository.GetAll();
                _categories.Clear();
                foreach (var cat in categoriesFromDatabase)
                {
                    _categories.Add(cat);
                }
                categoriesDataGridView.DataSource = _categories;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }


        private void loadCategoriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(!useWindowsAuthCheckbox.Checked && (string.IsNullOrWhiteSpace(loginTextbox.Text) || string.IsNullOrWhiteSpace(passwordTextbox.Text)))
                {
                    throw new InvalidOperationException(
                        "please provide login and password or choose Windows authentication");
                }
                _categoryRepository = useWindowsAuthCheckbox.Checked ? new CategoryRepository() : new CategoryRepository(loginTextbox.Text, passwordTextbox.Text);
                var categoriesFromDatabase = _categoryRepository.GetAll();
                foreach (var cat in categoriesFromDatabase)
                {
                    _categories.Add(cat);
                }
                categoriesDataGridView.DataSource = _categories;
                categoriesGroup.Visible = true;
                saveChangesButton.Visible = true;
                deleteCategoriesButton.Visible = true;
                categoriesDataGridView.Visible = true;
                categoriesDataGridView.AllowUserToAddRows = true;
                var categoryIdColumn = categoriesDataGridView.Columns[nameof(Category.CategoryID)];
                if (categoryIdColumn != null)
                {
                    categoryIdColumn.ReadOnly = true;
                }
                loginLabel.Enabled = false;
                passwordLabel.Enabled = false;
                useWindowsAuthCheckbox.Enabled = false;
                groupBox1.Enabled = false;
                loadCategoriesButton.Enabled = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void useWindowsAuthCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (useWindowsAuthCheckbox.Checked)
            {
                loginTextbox.Enabled = false;
                passwordTextbox.Enabled = false;
                loginLabel.Enabled = false;
                passwordLabel.Enabled = false;
            }
            else
            {
                loginTextbox.Enabled = true;
                passwordTextbox.Enabled = true;
                loginLabel.Enabled = true;
                passwordLabel.Enabled = true;
            }
        }

        private void deleteCategoriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (var index = 0; index < categoriesDataGridView.SelectedRows.Count; index++)
                {
                    var row = categoriesDataGridView.SelectedRows[index];
                    var categoryToDelete = (Category)row.DataBoundItem;
                    if (!string.IsNullOrWhiteSpace(categoryToDelete.CategoryID))
                    {
                        _categoryRepository.DeleteCategory(categoryToDelete);
                    }
                    _categories.RemoveAt(row.Index);
                }
                MessageBox.Show("deleted successfully", "deleted");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void updateCategoriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_categories.Any(x => string.IsNullOrWhiteSpace(x.CategoryName) || string.IsNullOrWhiteSpace(x.Description)))
                {
                    throw new InvalidOperationException("please fill in all category names and descriptions");
                }
                var newCategories = _categories.Where(x => x.CategoryID == null).ToArray();
                foreach (var category in newCategories)
                {
                    var id = _categoryRepository.AddCategory(category);
                    category.CategoryID = id;
                }
                foreach (var category in _categories.Except(newCategories))
                {
                    _categoryRepository.UpdateCategory(category);
                }
                MessageBox.Show("updated successfully", "updated");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }
    }
}