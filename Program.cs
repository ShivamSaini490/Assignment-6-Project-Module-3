/*Project Description:
The Student Management System is a dynamic and comprehensive C# Windows (Or Web) Form
Application designed to streamline the management of student-related information within an
educational institution. This project encompasses modules that cover key aspects of student data,
faculty details, attendance tracking, marks management, and financial records. As you progress through
the modules, you'll gain practical experience in C# programming, database interactions using SQL Server,
and the development of user-friendly interfaces.*/

using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

/*Module 3: Additional Features
 *
1.Error Logging and Exception Handling:
• Implement logging of errors (into File or Database) and exceptions for better application
reliability.*/
public class ErrorLogger
{
    private readonly string logFilePath;

    public ErrorLogger(string filePath)
    {
        logFilePath = filePath;
    }

    public void LogError(string errorMessage)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now} - ERROR: {errorMessage}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing to log file: " + ex.Message);
        }
    }
}

public partial class YourForm : Form
{
    private ErrorLogger errorLogger;

    public YourForm()
    {
        InitializeComponent();
        errorLogger = new ErrorLogger("error_log.txt");
    }

    private void SomeMethod()
    {
        try
        {
        }
        catch (Exception ex)
        {
            errorLogger.LogError(ex.Message);
            MessageBox.Show("An error occurred. Please check the error log for details.");
        }
    }
}


/*2.Enhanced UI:
• Improve the user interface of forms using WinForms features.*/


GroupBox groupBoxStudentInfo = new GroupBox();
groupBoxStudentInfo.Text = "Student Information";
groupBoxStudentInfo.Location = new Point(10, 10);
groupBoxStudentInfo.Size = new Size(300, 150);

this.Controls.Add(groupBoxStudentInfo);

TabControl tabControl = new TabControl();
tabControl.Dock = DockStyle.Fill;

TabPage tabPageStudents = new TabPage("Students");
TabPage tabPageFaculty = new TabPage("Faculty");

tabControl.TabPages.Add(tabPageStudents);
tabControl.TabPages.Add(tabPageFaculty);

this.Controls.Add(tabControl);

DataGridView dataGridViewStudents = new DataGridView();
dataGridViewStudents.Dock = DockStyle.Fill;


this.Controls.Add(dataGridViewStudents);
ToolStrip toolStrip = new ToolStrip();
toolStrip.Items.Add(new ToolStripButton("Students"));
toolStrip.Items.Add(new ToolStripButton("Faculty"));

this.Controls.Add(toolStrip);

this.BackColor = Color.LightGray;
this.Font = new Font("Arial", 10, FontStyle.Regular);

/*3.Testing:
• Test the application thoroughly, ensuring all CRUD operations work as expected.*/

/*Testing a comprehensive application involves verifying that all components and features perform as expected. In a Student Management System, you would want to ensure that CRUD (Create, Read, Update, Delete) operations for student data, faculty details, attendance tracking, marks management, and financial records work correctly. Below, I'll provide you with an outline for testing each module.

### Testing Plan:

#### 1. **Students Module:**
   - **Create:**Add new student records and verify they are correctly added to the database.
   - **Read:**Retrieve student records and verify that the displayed data matches the data in the database.
   - **Update:**Edit existing student records and verify the changes are reflected in the database.
   - **Delete:**Remove student records and ensure they are no longer present in the database.

#### 2. **Faculty Module:**
   - **Create:**Add new faculty records and verify they are correctly added to the database.
   - **Read:**Retrieve faculty records and verify that the displayed data matches the data in the database.
   - **Update:**Edit existing faculty records and verify the changes are reflected in the database.
   - **Delete:**Remove faculty records and ensure they are no longer present in the database.

#### 3. **Attendance Tracking Module:**
   - **Mark Attendance:**Use the attendance tracking feature to mark attendance for students in different classes.
   - **View Attendance:**Check the attendance records for specific dates and classes to verify correctness.
   - **Update Attendance:**Edit attendance records and ensure the changes are saved correctly.
   - **Delete Attendance:**Remove attendance records and ensure the database reflects the changes.

#### 4. **Marks Management Module:**
   - **Record Marks:**Add marks for students in various subjects and verify the data is correctly stored.
   - **View Marks:**Check the marks for specific students and subjects to ensure accuracy.
   - **Update Marks:**Modify existing marks and ensure the changes are saved correctly.
   - **Delete Marks:**Remove marks and verify the database reflects the changes.

#### 5. **Financial Records Module:**
   - **Record Fees:**Add financial records for student fees and verify correct storage.
   - **View Financial Records:**Check financial records for specific students and ensure accuracy.
   - **Update Financial Records:**Modify existing financial records and verify changes are saved correctly.
   - **Delete Financial Records:**Remove financial records and ensure the database reflects the changes.

### General Testing Considerations:

1. **Boundary Testing:**
   -Test with minimum and maximum input values.
   - Ensure the application handles edge cases gracefully.

2. **Negative Testing:**
   -Attempt operations that should fail and ensure proper error messages are displayed.
   - Test with invalid input and ensure appropriate validation messages are shown.

3. **Concurrency Testing:**
   -Simulate multiple users performing operations simultaneously to ensure data consistency.

4. **Performance Testing:**
   -Test the application's performance by adding a large number of records.
   - Check if response times are acceptable.

5. **Security Testing:**
   -Ensure that user authentication and authorization mechanisms are effective.
   - Test for SQL injection and other security vulnerabilities.

6. **Usability Testing:**
   -Evaluate the user interface for clarity, ease of use, and consistency.
   - Gather feedback from potential end-users.

7. * *Cross - Browser Testing(for Web Applications):**
   -Ensure the application works consistently across different browsers.

8. **Cross-Device Testing (for Web Applications):**
   -Test the application on various devices to ensure responsiveness.

### Test Automation:

Consider creating automated tests using a testing framework like NUnit or MSTest. Automated tests can help streamline the testing process, especially for repetitive tasks or regression testing.

Remember to document test cases, record test results, and prioritize fixing any identified issues. Testing is an iterative process, and continuous testing and feedback help improve the quality of your application over time.
*/