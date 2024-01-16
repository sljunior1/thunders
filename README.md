# thunders
Foi utilizado docker para rodar uma imagem do SQL Server. Para executar, basta utilizar o seguinte comando:
docker run --hostname=BDThundersTask --user=mssql --mac-address=02:42:ac:11:00:02 --env=ACCEPT_EULA=Y --env=MSSQL_SA_PASSWORD=!WeAZ#Hq2i --env=PATH=/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin --env=MSSQL_RPC_PORT=135 --env=CONFIG_EDGE_BUILD= --env=MSSQL_PID=developer -p 1433:1433 --restart=no --label='com.microsoft.product=Microsoft SQL Server' --label='com.microsoft.version=16.0.4105.2' --label='org.opencontainers.image.ref.name=ubuntu' --label='org.opencontainers.image.version=22.04' --label='vendor=Microsoft' --runtime=runc -d mcr.microsoft.com/mssql/server:2022-latest

Foi utilizado também Migration, a connectionString utilizada é: "Server=localhost;Database=BDThundersTask;User Id=sa;Password=!WeAZ#Hq2i;Trusted_Connection=false;MultipleActiveResultSets=true;Encrypt=false;"
