I would be adding following steps to make sure that application is fit for enterprise.

- Adding proper error handling by capturing and logging exceptions and provide meaningful error messages.
- Adding more asynchronous code to avoid deadlock secnarios.
- Adding mode configuration seetings, such as the API url to make the application more configurable.
- Integrate logging mechanism to capture important events and errors for monitoring debugging.
- Implementing necessary authentication mechanism for API autnentication, such as OAuth, API keys etc.
- Considering using dependency injection for managing and injecting dependencies like HttpClient.
- Organizing the code into separate classes/services to adhere to SOLID principals.
- Implementing cache mechanism to reduce unnecessary API calls.
