@echo off
cls
echo Deteniendo Oracle.
docker stop oracle-xe

echo Deteniendo RabbitMQ.
docker stop rabbitmq

rem echo Deteniendo sql server
rem docker stop sqlserver

echo Servicios detenidos.
pause