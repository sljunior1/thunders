# thunders
Foi utilizado docker para rodar uma imagem do SQL Server. Para executar, basta utilizar o seguinte comando:
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=!WeAZ#Hq2i"   -p 1433:1433 --name BDThundersTask --hostname BDThundersTask  -d ` mcr.microsoft.com/mssql/server:2022-latest

Foi utilizado também Migration, a connectionString utilizada é: "Server=localhost;Database=BDThundersTask;User Id=sa;Password=!WeAZ#Hq2i;Trusted_Connection=false;MultipleActiveResultSets=true;Encrypt=false;"
