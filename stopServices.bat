@echo off
cls
echo Deteniendo Oracle.
docker stop oraclexe

echo Deteniendo RabbitMQ.
docker stop rabbitmq

echo Servicios detenidos.
pause