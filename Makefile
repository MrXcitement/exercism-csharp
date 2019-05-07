image ?= mrbarker/exercism-csharp:0.1.0
name ?= exercism-csharp

all: run

run:
	mkdir -p $(CURDIR)/.config/exercism
	docker run \
		-dit \
		-v $(CURDIR)/.config/exercism:/root/.config/exercism \
		-v $(CURDIR):/workspace \
		--name $(name) \
		$(image)

exec:
	docker exec -it $(name) bash

stop:
	docker stop $(name)

kill:
	docker kill $(name)

rm:
	docker rm $(name)
