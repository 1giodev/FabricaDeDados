#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM microsoft/dotnet:3.1-aspnetcore-runtime
COPY dist /app
WORKDIR /app
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet","FabricaDeDadosWeb.dll"]