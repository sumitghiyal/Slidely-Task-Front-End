# Frontend Form Application
Overview
This application allows users to create new submissions and view existing submissions. The frontend is built using Visual Basic and provides an intuitive interface for data entry and navigation.

Forms
1. Main Form
   Button: View Submissions
   Description: Opens the form to view all submissions.
   Shortcut Key: Ctrl + V

   Button: Create New Submission
   Description: Opens the form to create a new submission.
   Shortcut Key: Ctrl + N
   
2. View Submissions Form
   Description: Displays a list of all submissions and allows navigation through them.
   Navigation Buttons:
     Previous: Navigate to the previous submission.
     Next: Navigate to the next submission.
   Fields Displayed:
     Name: Name of the submitter.
     Email: Email address of the submitter.
     Phone: Phone number of the submitter.
     GitHub Link: GitHub profile link of the submitter.
     Stopwatch Time: Time recorded by the stopwatch.
   
3. Create Submission Form
   Description: Allows users to input and submit new data.
   Fields:
     Name: Input field for the name.
     Email: Input field for the email address.
     Phone: Input field for the phone number.
     GitHub Link: Input field for the GitHub profile link.
     Stopwatch Time: Input field for the stopwatch time.
   
   Keyboard Shortcuts
     Ctrl + V: Opens the View Submissions Form from the Main Form.
     Ctrl + N: Opens the Create Submission Form from the Main Form.

Setup Instructions
  Clone the Repository:
  Copy code git clone <repository-url>
  Open the Solution: Open the .sln file in Visual Studio.
  Run the Application: Press F5 or select Start Debugging from the Debug menu.

Server Requirements
  Ensure the server is running and accessible at http://localhost:3000. The server should have the following endpoints:

  GET /ping: Returns a simple True response to check server connectivity.
  POST /submit: Accepts submission data.
  GET /read: Returns all submission data or a specific submission based on the index provided.
