# envoy-problemsolving

A basic tutorial introduction to gRPC in Go. https://grpc.io/docs/languages/go/basics/
export PATH="$PATH:$(go env GOPATH)/bin"
Hints on getting the proto files working https://github.com/maximilienandile/demo-grpc

How to build go image. https://docs.docker.com/language/golang/build-images/
docker build -t demo_greeter:multistage -f Dockerfile.multistage .

Envoy configuration for Json transpose :https://www.envoyproxy.io/docs/envoy/v1.26.2/configuration/http/http_filters/grpc_json_transcoder_filter

Generating proto files and client module for a given language see makefile


https://github.com/envoyproxy/envoy/issues/6999
https://errindam.medium.com/json-http-transcoding-to-grpc-using-envoy-934ffe343983


protoc -I ~/googleapis -I . --include_imports --descriptor_set_out=helloworld.pb helloworld.proto

