This project is an implementation of OData (Open Data Protocol) using ASP.NET Core. It demonstrates how to create RESTful APIs with advanced query capabilities like filtering, sorting, counting, and projection. 

### API Endpoints

- **GET /odata/Companies**
  - Retrieves a list of companies.
- **GET /odata/Companies({id})**
  - Retrieves a specific company by ID.
- **POST /odata/Companies**
  - Creates a new company.
- **PUT /odata/Companies({id})**
  - Updates an existing company.
- **DELETE /odata/Companies({id})**
  - Deletes a company.

### OData Query Options

Some common queries:

- **$metadata: Retrieves the metadata document describing the Entity Data Model (EDM) for the service.**
  - *Example:* `/odata/$metadata`
- **Retrieve all entities:**
  - *Example:* `/odata/companies`
- **$filter: Filters results based on specific criteria.**
  - *Example:* `/odata/companies?$filter=Size%20gt%2020&$count=true` (Retrieve companies with size greater than 20)
- **$expand: Expands related entities.**
  - Example: `/odata/Companies?$expand=Products`` (Retrieve company data with product information)
- **Retrieve by ID: Retrieves a specific entity by its ID.**
  - *Example:* `/odata/companies(1)` (Retrieve company by ID)
- **$filter with multiple conditions: Filters results based on multiple criteria.**
  - *Example:* `/odata/companies?$filter=Id%20eq%201%20or%20Id%20eq%203` (Retrieve companies with Id equal to 1 or 3)
- **$orderby: Sorts the results by one or more properties.**
  - *Example:* `/odata/companies?$orderby=Id%20desc` (Retrieve companies ordered by Id in descending order)
- **Retrieve by ID with expansion.**
  - *Example:* `/odata/companies(2)?$expand=Products` (Retrieve companies with Id equal to 2 and expand their list of products)
- **$select: Limits the properties returned in the response.**
  - *Example:* `/odata/companies?$select=Name` (Retrieve company names only)
- **Combining multiple query options.**
  - *Example:* `/odata/companies?$orderby=Id%20desc&$expand=Products&$top=2&$select=Name` (Retrieve names of top 2 companies ordered by Id in descending order and expand their list of products) 
