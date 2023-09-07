# Microservices

In this project, I developed a microservices-based course purchase platform similar to Udemy. The project consists of a total of 6 services, each using a different database. The services are run as Docker
containers. Additionally, IdentityServer's free template, is4aspid, is used for authentication and authorization processes. Microservices communication is achieved using ApiGateway, leveraging the
automatic binding feature of the ocelot library. Furthermore, RabbitMQ is used for asynchronous communication between orders and payments. A Shared Library class is also created to contain common
classes used across services.

## Services
**1.** **Basket Service:** Responsible for managing the shopping cart. This service defines basic CRUD operations related to the cart. Redis is used as the database.

**2.** **Catalog Service:** Manages courses and categories. Course operations are handled by this service, and it uses the NoSQL database MongoDB.

**3.** **Discount Service:** Used to apply discounts in the shopping cart. Discounts can be applied based on user-defined discount codes. PostgreSql is used as the database, and Dapper is the chosen ORM tool.

**4.** **FakePayment Service:** Simulates the payment process.

**5.** **Order Service:** Developed using CQRS/DDD principles. Payment processes are managed based on messages received from the FakePayment service. MsSql Server is the database used.

**6.** **PhotoStock Service:** Manages course images. Docker is used to bind these files to a local folder.

## Technologies and Tools
+ DockerFiles and configurations are created for Docker containers.
+ IdentityServer (is4aspid) is used for authentication and authorization.
+ ApiGateway and the ocelot library are used for microservices communication.
+ RabbitMQ is chosen for asynchronous communication.
+ A Shared Library is created to hold common classes.

This project demonstrates a successful implementation of a microservices architecture for a course purchase platform similar to Udemy. It showcases independent microservices using different databases, 
asynchronous payment processes, and the integration of various technologies.
