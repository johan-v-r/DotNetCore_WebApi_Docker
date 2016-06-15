FROM microsoft/dotnet
ADD . jvrtest
WORKDIR jvrtest
RUN dotnet restore
EXPOSE 5000
CMD dotnet run
