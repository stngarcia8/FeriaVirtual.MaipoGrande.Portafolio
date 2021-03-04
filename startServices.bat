@echo off
cls
echo Iniciando Oracle.
docker start oraclexe

echo Iniciando RabbitMQ.
docker start rabbitmq

echo Servicios iniciados.
pause