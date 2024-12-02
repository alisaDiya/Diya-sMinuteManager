# Minutes Management Application - Windows Forms

## Application Name
**Minutes Management System**

## Version
**Version 1.0**

---

## Description
The **Minutes Management System** is a Windows Forms application developed to streamline the management of municipal and organizational meetings. It is designed to efficiently record, update, and track meeting details, including types, agendas, and outcomes. This application ensures effective collaboration, accountability, and continuity between meetings.

---
## Demo video of how to use the application
## Features

### Meeting Management
- **Meeting Types**:
  - MANCO
  - Finance
  - Project Team Leaders (PTL)
- Create and manage monthly meetings for each type.
- Automatically associate new meetings with the previous meeting of the same type for status updates and progress tracking.

### Meeting Items
- Each meeting is associated with multiple actionable items (Meeting Items).
- Track the lifecycle of a Meeting Item, including its status, assigned actions, and responsible person.
- Carry forward unresolved Meeting Items to subsequent meetings.

### Meeting Item Status
- Update the status of a Meeting Item after every meeting.
- Maintain a complete history of a Meeting Item’s statuses and actions across multiple meetings.
- Assign responsible persons and actions for each Meeting Item at every meeting.

### System Functions
1. **Capture New Meeting**:
   - Select the meeting type (e.g., MANCO, Finance, PTL).
   - Specify the date and time of the meeting.
   - Display Meeting Items from the previous meeting of the same type.
   - Allow users to select Meeting Items to carry forward.
   - Create a new meeting with the selected items.

2. **Update Meeting Item Status**:
   - Recall Meeting Items by selecting the relevant meeting.
   - Update the status of selected Meeting Items.
   - Assign actions and responsible persons for the Meeting Item.
   - Save updates to ensure accurate tracking.

---

## Installation

### Prerequisites
1. **Software Requirements**:
   - Microsoft Visual Studio (2019 or 2022, minimum version 16.6.3)
   - .NET Framework plugin
   - Windows 10 or later

2. **Hardware Requirements**:
   - **Processor**: 1.8 GHz 64-bit or faster
   - **RAM**: 4 GB or more

### Installation Steps
1. Download the application files as a ZIP archive.
2. Extract the ZIP file and place the unzipped folder in `C:\`.
3. Open the project in Visual Studio.
4. Build and run the project by clicking the green "Play" button.
5. Follow the application's on-screen instructions.

## Frequently Asked Questions (FAQs)

### Q: What is the purpose of this application?
**A:** To facilitate efficient meeting management, track actionable items, and ensure continuity between meetings.

### Q: How are Meeting Items tracked?
**A:** Each Meeting Item is associated with a meeting, and its status, actions, and assigned person are updated after every meeting.

### Q: Can I carry forward unresolved Meeting Items?
**A:** Yes, unresolved Meeting Items from previous meetings can be carried forward when creating a new meeting.

### Q: How do I update the status of a Meeting Item?
**A:** Select the meeting, choose the relevant Meeting Item, update its status, and save the changes.

---

## Developer Information
**Developer**: Alisa Diya Thool  
**Email**: alisadthool@gmail.com

---

## Troubleshooting

### Problem: Application crashes at startup.
- **Cause**: Insufficient system resources or conflicting background applications.
- **Solution**: Close unnecessary applications and restart the program.

### Problem: Meeting Items not displayed for a new meeting.
- **Cause**: No Meeting Items were marked as unresolved in the previous meeting.
- **Solution**: Ensure items are marked correctly in previous meetings before proceeding.

---

Thank you for choosing the **Minutes Management System**! For support or suggestions, contact the developer.

