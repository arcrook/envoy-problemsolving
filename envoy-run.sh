docker run --rm -it \
      -v $(pwd)/envoy-demo.yaml:/envoy-demo.yaml \
      -v $(pwd)/helloworld/helloworld.pb:/etc/envoy/protos/helloworld.pb \
      -p 10000:10000 \
      -p 8080:8080 \
      -p 9901:9901 \
      -p 8500:8500 \
      envoyproxy/envoy:v1.26.1 \
      -c /envoy-demo.yaml
