Project – Music School Management System
========================================

Type – Education Management
---------------------------

Description
-----------

A web app that will enable music schools to manage student enrollments, staff
schedules / hire, sending mass notifications to students and their parents,
share lesson plans, sheet music, online tutorials. The app will consist of an
informational front page, complete with a news and events section, teacher
profiles, available classes and so on. Several roles with separate permissions
will be available for assigning. It will have a careers page where teachers can
find job openings and apply with their CV.

1.  **Guest** – Can register and opt in to create either a student or a teacher
    profile. Student profiles will be automatically created. Teacher profile
    applications will go for approval with the designated responsible person
    (i.e. the principal / director). A confirmation email will be received upon
    account creation. Possible integration with SendGrid.

2.  **Student** – Can view current schedule. Can request enrollment with a
    particular teacher. The student can view resources shared by the teachers
    for each lesson past or upcoming. For example, the student will be able to
    download the sheet music assigned to him for his next piano lesson to print
    and study. Students will register with their own email but they must also
    fill in their parent/guardian’s email. The parents will receive the same
    lesson notifications and informational emails that the students will, so
    that they can know what is happening at any point. The parent will also be
    granted access to their child’s lesson schedule. No registration necessary,
    a link will be emailed to them.

3.  **Teacher** – can schedule lessons with the students that are enrolled in
    his classes, upload resources to each lesson, and can request lesson
    cancellation which should be approved by the director first. The teacher
    must write a note with the cancellation request which will be emailed to the
    student and his parent/guardian once approved the lesson status is changed
    to cancelled/postponed and the student receives a notification email.

4.  **Principal** – This will typically be assigned to the school director. In
    this role the user can create profiles for teachers, edit areas of the
    website, post jobs on the careers page.

5.  **HR** – role can be optionally added for big institutions with their own hr
    department.

6.  **Admin** – unlimited permissions. Can assign roles to anyone, including
    principal.

Optional features (to be expanded upon in the future):

1.  Student payment system – allows payments for lessons and records which
    lessons are paid for or if the student is enrolled on monthly/yearly plan

2.  Employee Payroll System – Each teacher can be assigned lesson payout amounts
    depending on subject and experience. At the end of each month the Principal
    can use the tool to calculate each teacher’s salary and generate a payslip.

3.  Mobile App that send push notifications with lesson reminders / events
    information.

Entities
--------

### Student

-   Id (string)

-   Username – will be auto generated. Username is a combination of First Name +
    first letter of last name.

-   Password (string)

-   Email (string)

-   Parent / Guardian Email (if under 18)

-   First Name (string)

-   Last Name (string)

-   DoB (DateTime)

-   Home Phone Number

-   Address

-   Mobile

### Employee

-   Id (string)

-   Username – will be auto generated. Username is a combination of First Name +
    first letter of last name.

-   Password (string)

-   Email (string)

-   First Name (string)

-   Last Name (string)

-   DoB (DateTime)

-   Mobile

-   Address

-   Roles

-   Subjects (list of subjects, can be 1 or many, principal can adjust exact
    subjects before approving teacher profile application)

-   HireDate (DateTime) – will be set by principal / hr when status is hired.

-   Currently Hired – bool Y/N

-   Base Salary

### Subject

-   Name

-   Description

### Lesson

-   Date

-   Resources

-   Teacher

-   Student(s)

-   Status
