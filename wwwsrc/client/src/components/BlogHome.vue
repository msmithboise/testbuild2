<template>
    <div id="blog-home">
        <div>
            <button @click="getPosts"></button>

            <div v-for="post in posts" :key="post.id">
                <h1>Test Blog Page</h1>
                {{post.body}}
                <p>{{post.author.email}}</p>

            </div>
        </div>
    </div>


</template>

<script>
    import { butter } from "@/buttercms";
    export default {
        name: "blog-home",
        mounted() {

            return "getPosts"

        },
        data() {
            return {
                page_title: "Blog",
                posts: [],
                catagories: []
            };
        },

        methods: {
            getPosts() {
                butter.post
                    .list({
                        page: 1,
                        page_size: 10
                    })
                    .then(res => {
                        console.log(res.data);
                        this.posts = res.data.data;
                    });
            }
        }


    };
</script>

<style>
</style>