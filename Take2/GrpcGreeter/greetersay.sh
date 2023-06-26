~/grpcurl -plaintext -proto Protos/greet.proto -d '{"name": "Brian"}' \
    localhost:8080 greet.Greeter/SayHello


~/grpcurl -plaintext -proto Protos/greet.proto -d '{"name": "Brian"}' \
    localhost:50333 greet.Greeter/SayHello