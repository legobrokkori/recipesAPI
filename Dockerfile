FROM microsoft/dotnet:2.1-sdk AS build-env
WORKDIR /source

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /source
COPY --from=build-env source/out .

CMD dotnet CookingAssist.dll --urls "http://*:$PORT"
