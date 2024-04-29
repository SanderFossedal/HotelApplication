# DAT154 - Assignment 4

## Info for members (NO)

Trellolink: [link](https://trello.com/invite/b/R0zWn6E6/ATTI32cdea285dce02d3af4900e89c843d86B9910112/assignment4)

Her er en kort oversikt over mappene:

- ~/booking -> dette er mappen  til kundenes bookingapplikasjon
	- Harald
- ~/frontdesk -> dette er mappen til hotellets resepsjonsapp
	- Martin og Sander
- ~/cleaning -> dette er mappen til hotellets vedlikeholdsarbeidere
	- Moses og Sindre

Alltid dobbeltsjekk med en i gruppa før dere pusher eller merger slik at vi unngår feil.

Husk alltid å pulle prosjektet før dere fortsetter å jobbe på den.

## Group

- [Harald Giskjegjerde Nilsen](https://github.com/haraldnilsen)
- [Martin Hansen](https://github.com/h600848)
- [Mussie Woldegebriel Tesfai](https://github.com/h147023)
- [Sander Fossedal](https://github.com/h600873)
- [Sindre Kjelsrud](https://github.com/SindreKjelsrud)

## Tasks

- A web application for customers to book rooms and check the status of their reservation. A simple login system is therefore required, but don’t waste too much time on this, make it simple.  
  Note that users should book their room based on room properties (number of beds, room size/quality, etc.) and not the room number itself.  
  You'll probably want to associate any booking with a room number behind the scenes though, to make it easier to search for available rooms. The user should be able to search for available rooms in a given time period, including searching
  by room properties.

- A desktop application used by the front desk of the hotel. This application should have full access to manage all the rooms and reservations of the hotel. The users should be able to add new reservations and delete reservations and associate a reservation with a particular room.  
  It should also be used when guests check in and out.  
  This program should also be used to register room service and maintenance requests for rooms

- An app is used by the cleaning, service and maintenance personnel. When the app loads, the user should be able to choose if he is a maintainer, cleaner, or service person. Once selected, the app should display a list of pending tasks, rooms where guests have checked out, but which have not been cleaned yet for the cleaners, room service requests for the service personnel and maintenance requests for the maintenance people.  
  The users of the app should be able to change the status of the app through the interface (new, in progress, finished), and attach notes to it (Which will be visible in the desktop app).  
  This app can be a desktop or a web app, the only requirement is that it does NOT use the same technology as the web app or front desk app. So if the web app is Web Forms, and the desktop is windows forms, this can be WPF or Microsoft MVC or blazor or a windows universal app or a Maui app.  
  The requirement of a different type is obviously an artificial demand, but used here to force you to plan out a bit more of a complex solution.

## Software

To successfully complete this project, you will need:

- Visual Studio 2022. If you do not have this already, it is available from your Azure DevTools account.

- A database. I you set one up on Azure [Your free student credits should cover this easily, just make sure to make it a basic tier], but I can also set up a database for you on dat154.hvl.no, or you can download SQL server from the Azure education hub and install it on a computer yourself. You can also use the development DB from Visual Studio, but this is a bit more tricky when you have multiple team members and multiple projects.

- A web server. The IIS Express is installed along with Visual Studio, and will work fine, just remember to set your web project to use static port numbers if other apps need to talk to it.

## Approval

To get it approved, it should contain the following:

- The 3 different apps in a (mostly) working condition. While we understand that you may have problems with some parts, a minimum requirement is that the basic framework and communication is up and running.

- Show us that you have actually thought a little bit about your architecture.

- Use shared libraries where appropriate.

- It should use .NET technologies. You are free to explore additional ones besides the ones we have covered, and I am open to adding things like a rich JavaScript framework to the web application, but it shouldn’t take over the main functionality.
