module.exports = {
  publicPath: './',
  transpileDependencies: ["vuetify"],
  chainWebpack: config => {
    config.plugin('VuetifyLoaderPlugin').tap(args => [{
      match (originalTag, { kebabTag, camelTag, path, component }) {
        if (kebabTag.startsWith('core-')) {
          return [camelTag, `import ${camelTag} from '@/components/core/${camelTag.substring(4)}.vue'`]
        }
        else if(kebabTag.startsWith('public-')){
          return [camelTag, `import ${camelTag} from '@/components/public/${camelTag.substring(6)}.vue'`]
        }
      }
    }])
  }
}

// kebab: public-nav-drawer
// camel: PublicNavDrawer

