username ?= mrbarker
imagename ?= exercism-csharp
tag ?= 0.1.0

.PHONY: docker-run docker-exec docker-stop docker-kill docker-rm
all: 

docker-run:
	mkdir -p $(CURDIR)/.config/exercism
	docker run \
		-dit \
		-v $(CURDIR)/.config/exercism:/root/.config/exercism \
		-v $(CURDIR):/workspace \
		--name $(imagename) \
		$(username)/$(imagename):$(tag)

docker-exec:
	docker exec -it $(imagename) bash

docker-stop:
	docker stop $(imagename)

docker-kill:
	docker kill $(imagename)

docker-rm:
	docker rm $(imagename)
