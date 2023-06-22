# CQRS And MediatR Pattern Implementation Using .NET Core 6 Web API 

# Directory Structure and File Descriptions

- Controllers
  - UserController.cs

- Models
  - User.cs

- Features
  - Commands {IRequest}
    - CreateUserCommand.cs
    - UpdateUserCommand.cs
    - DeleteUserCommand.cs

  - Queries {IRequest}
    - GetUserQuery.cs
    - GetUsersQuery.cs

  - Handlers {IRequestHandler}
    - CreateUserCommandHandler.cs
    - UpdateUserCommandHandler.cs
    - DeleteUserCommandHandler.cs
    - GetUserQueryHandler.cs
    - GetUsersQueryHandler.cs

- Repositories
  - Interfaces
    - IUserRepository.cs
  - UserRepository.cs

- Exception
 
- Startup.cs


# Dependencies

```
install-package MediatR
```

```
MediatR.Extensions.Microsoft.DependencyInjection
```
# In Program
```
builder.Services.AddMediatR(typeof(Program));
```

# In Program
```
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
```
