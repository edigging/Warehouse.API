# Warehouse API

Warehouse API is a nice and sexy service for working with Naburszh Warehouse.


## API
API is exposed through the following endpoint – 
> `http://warehouse-api.azurewebsites.net/api`

The endpoint is protected by the **authentication token**. The token must be provided via `x-client-id` header

### * Creating a new outbound request 

> `POST /outbounds`

Example body:

```json 

    {
		
	}
```
**Response: 200 OK**

```json
{  
  
}


```

Any status except 200 OK should be considered as an error.

**Response: 401 Unauthorized** - when x-client-id is missing or is wrong

**Response: 400 Bad Request** - for custom errors
```
{
  "code": 400,
  "message": "Internal Error"
}
```