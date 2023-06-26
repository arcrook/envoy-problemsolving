curl -X POST -d '{"name" : "bob" }' localhost:8500/v1/say/bob -v;
#curl -X POST -d '{"name": "Sean"}' localhost:8500/greeter.greet/SayHello -v -I -H "Content-Type: application/json";

# curl -X GET localhost:8500/v1/employee/id -v -I;

#curl -X POST -d '{"name": "Sean", "id": "21"}' \
#-H "Content-Type: application/json" \
#http://localhost:8500/v1/reservations;

#curl -X PUT -d '{"name": "Sean", "id": "55"}' -H "Content-Type: application/json" http://localhost:8500/v1/employee/id;

#curl -X DELETE -d '{ "id": "98"}' -H "Content-Type: application/json" http://localhost:8500/v1/employee/id;


curl -X POST --data "$(cat complexRequest1.json)" @ -H "Content-Type: application/json" http://localhost:8500/v1/Complex/CalculateMap
curl -X POST --data "$(cat complexRequest1.json)" @ -H "Content-Type: application/json" http://localhost:8500/v1/Complex/CalculateMap