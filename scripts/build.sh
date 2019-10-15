#!/bin/bash

#call from parent directory

docker build \
    -t intellego \
    -f ./intelliGo/Dockerfile \
    .