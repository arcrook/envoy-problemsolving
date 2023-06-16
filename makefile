generate_grpc_go_module:
protoc \
	-I ~/googleapis -I . \
	--go_out=helloworld \
	--go_opt=paths=source_relative \
	--go-grpc_out=helloworld      \
	--go-grpc_opt=paths=source_relative  \
	helloworld.proto


generate_pb_for_envoy:
    protoc \
	-I${GOOGLEAPIS_DIR} \
	-I. \
	--include_imports \
	--include_source_info \
    --descriptor_set_out=helloworld/helloworld.pb \
	helloworld.proto
