task :default => [:build]

multitask :build => ["ruby:csharp:build", "eiffel:build", "eiffel:csharp:build", "erlang:build", "erlang:build", "haskell:build", "haskell:csharp:build"]

namespace "ruby" do
	namespace "csharp" do
		task :build => ['ruby/helloweb.exe']
	end
end

namespace "eiffel" do
	task :build => ['bin/clock']

	namespace "csharp" do
		task :build => ['eiffel/clock.exe']	
	end
end

namespace "erlang" do
	task :build => ['bin/pingpong.beam']
end

namespace "haskell" do
	task :build =>  ['bin/quicksort']
	namespace "csharp" do
		task :build => ['haskell/quicksort.exe']
	end
end

directory 'bin'

rule '.exe' => '.cs' do |t|
	Rake::Task['bin'].invoke
	sh "dmcs #{t.source} -out:bin/#{t.name.pathmap('%f')}"
end

file 'bin/quicksort' do |t|
	Rake::Task['bin'].invoke
	sh "ghc --make haskell/quicksort.hs -o #{t.name}"
end

file 'bin/pingpong.beam' do |t|
	Rake::Task['bin'].invoke
	sh "erlc -o bin erlang/pingpong.erl"
end

file 'bin/clock' do |t|
	Rake::Task['bin'].invoke
	sh "cd bin; ec ../eiffel/clock.e; cd .."
end