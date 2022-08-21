[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) <br/>
[![LinkedIn](https://img.shields.io/badge/linkedin-%230077B5.svg?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/alejandro-alemany/)<br/>
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)<br/>
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="#">
    <img src="https://miro.medium.com/max/1400/1*wvPlEuyPwIux9_WX-eGf9Q.png" alt="Logo" width="400" height="400">
  </a>
  
 <h3 align="center">.Net Microservice with Acelot API gateway</h3>

  <p align="center">
    Alejandro Alemany
    <br />
    <a href="https://github.com/AlrxKali/.Net/edit/master/StoreMS"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/AlrxKali/.Net/edit/master/StoreMS">Report Bug</a>
    ·
    <a href="https://github.com/AlrxKali/.Net/edit/master/StoreMS">Request Feature</a>
  </p>
</p>

<hr>

### What is a monolithic Architecture?

Monolithic architectures are designed to make it possible for different companies to carry out their daily business activities with all the necessary components in a single application and in a logical way in each case. Two examples of prevalent monolithic architectures are ERP (Enterprise Resource Planning) and CRM (Customer Relation Management).

To solve this type of problem, SOA (Service Oriented Architecture) was created, a type of architecture in which the application can be decoupled into small modules known as services. All these services are integrated using an aggregation layer called a bus. All services communicate through this service bus. Over time, this application can become monolithic over time since all services are integrated with the same layer.

![image](https://user-images.githubusercontent.com/55760198/185811848-a46b9cf7-8045-4f6d-a306-4f658da306a7.png)


### What is a Microservice Architecture?

Microservices are both an architectural style and a way of programming software. With microservices, applications are broken down into their smallest, independent elements. Unlike the traditional, monolithic approach to applications, where everything is built into one piece, microservices are separate elements that work together to perform the same tasks.

Each one of those elements or processes is a microservice. This approach to software development values granularity, simplicity, and the ability to share a similar process across multiple applications. It is a critical element of optimizing application development toward a cloud-native model.

However, the biggest question is, what are the benefits of using a microservices infrastructure? Simply put, the goal is to deliver quality software faster. While this can be achieved with microservices, other issues must be considered. For example, splitting applications into microservices is not enough; they need to be managed and coordinated, and the data they create and modify.

![image](https://user-images.githubusercontent.com/55760198/185812470-a1444fda-3d61-4836-b285-a56bd7b84c01.png)

The image above shows the architecture that we will follow in this project.

### **Up to now, the project is not complete, and the only microservice that is entirely functional for GET and POST is the Catalog service.**

### What is the API gateway

API Gateways are a layer between the client and the services it relies on. Sometimes called "reverse proxy," they act as a single entry point for the customer to your services. For example, an API gateway would be a reception desk in front of an office building. They're in charge of routing calls, stopping unexpected visitors, and ensuring packages arrive at the right place. 

Of the use cases for an API Gateway, the most common is routing. It is similar to this: 
1. A client sends a request to the gateway. 
2. The gateway processes and sends the request to the Service. 
3. The Service responds to the gateway. 
4. The gateway processes the response and sends it to the client.

### API's Documentation

#### Overview

The goal of this project is to test the microservice architecture with the help of Ocelot Gateway. 
This API's documentation will continue growing as the project size increases. So far, there are only 
two end-points for GET all data stored in the database (no filtered) and to POST products to the catalog 
database. 

#### Tutorial

1. Clone project to local. 

```
git clone git@github.com:AlrxKali/.Net.git
```

2. Open StoreMS
3. Open Solution with Visual Studio
4. Right click on solution -> build solution
![image](https://user-images.githubusercontent.com/55760198/185813640-a0d4e015-6e90-483b-ba8e-4988c6580f40.png)
5. Run Solution
![image](https://user-images.githubusercontent.com/55760198/185813606-829be367-b9fc-4f6d-a3fe-5f40d801a447.png)
