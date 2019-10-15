#!/bin/bash

docker run \
    -p 0.0.0.0:9001:80 \
    --name intellego \
    -d \
    intellego
