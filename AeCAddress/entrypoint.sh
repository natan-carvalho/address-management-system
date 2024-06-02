#!/bin/sh
# adding dotnet tools in path
export PATH="$PATH:/root/.dotnet/tools"
# install dotnet-ef
dotnet tool install --global dotnet-ef
# install libs
dotnet restore
# Run migrations
dotnet ef database update
# Run project
dotnet run --urls http://0.0.0.0:5000