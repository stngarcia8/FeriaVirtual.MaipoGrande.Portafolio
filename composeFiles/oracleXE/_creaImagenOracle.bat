@echo off
cls
echo Creando imagen de oracle.
docker build --force-rm=true --no-cache=true -f Dockerfile.xe -t oracle/database:18.4.0-xe .

echo imagen creada
echo Creando contenedor
docker run --name oracle-xe -p 1521:1521 -p 5500:5500 -e ORACLE_PWD=aVaras_08 -e ORACLE_CHARACTERSET=AL32UTF8 -v d:/containers/volumenes/script/oracle:/script_files oracle/database:18.4.0-xe
pause