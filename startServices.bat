@echo off
cls
echo Iniciando Oracle.
docker start oracle-xe

echo Iniciando RabbitMQ.
docker start rabbitmq

rem echo Iniciando sql server
rem docker start sqlserver

echo Servicios iniciados.
pause