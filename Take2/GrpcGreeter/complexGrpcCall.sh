~/grpcurl -plaintext -proto Protos/greet.proto -d @ \
    localhost:5038 greet.ComplexService/CalculateMap <compleRequest.json