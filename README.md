# Taxi ORM API
A simple API resembling a Taxi travel flow and its entities. This project was created for study purposes, and will be used for learning and practicing new techniques, libraries, etc.

***

Entity Relationship Diagram (ERD) of the project:

![image](https://user-images.githubusercontent.com/70535363/170888408-5dc96d0d-1806-4808-8885-a93162beab0d.png)

***

## How to run and test the project

1. Clone the repository;
2. Open the **appsettings.json** file and change the connection string to match your PostgreSQL username and passowrd (you can also change the database name if you would like to do so);
3. Create a new PostgreSQL database with the same name as specified at the connection string;
4. In the created database, run the **CreateTables.sql** script, which is located at "Scripts/CreateTables.sql", to create the tables and its constraints;
5. Open the **TaxiOrmApi.sln** at your chosen IDE;
6. Run the project.

Now, with the application running, you will be able to send requests to the resources through the **http://localhost:7042** endpoint.

Soon the Swagger will be configured to create an appropriate documentation of the API and for better testing.
