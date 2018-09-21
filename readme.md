```sh

docker build -t justfortesting .

docker run -e "ASPNETCORE_ENVIRONMENT=Development" -it --rm -p 8100:80 --name justfortesting justfortesting

docker tag justfortesting:latest 127.0.0.1:5000/justfortesting:latest

docker push 127.0.0.1:5000/justfortesting:latest

```

docker pull valorzhong/justfortesting

docker tag justfortesting:latest valorzhong/justfortesting:latest

docker push valorzhong/justfortesting:latest
