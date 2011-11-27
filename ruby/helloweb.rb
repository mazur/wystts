# This code requires the sinatra gem to be installed.
# Run the application by typing:
#
# ruby helloweb.rb
#
# Go to:
# http://localhost:4567/Hello/stranger
# http://localhost:4567/Hi/stranger

require 'sinatra'

get '/hello/:name' do |name|
	"Hello #{name}!"
end

get('/hi/:name') { |name| "Hi #{name}" }

# To see how get is implemented please look at sinatra 
# source code.
#
# http://github.com/sinatra/sinatra

