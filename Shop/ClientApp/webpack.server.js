const path = require('path');

module.exports = {
  output: {
    filename: 'my-first-webpack.bundle.js',
  },
  module: {
    rules: [
      { test: /\.txt$/, use: 'raw-loader' },
      { test: /\.(png|jpg|JPG|jpeg|gif|svg)$/, use: ['url-loader?limit=25000'] }],
  },
};
