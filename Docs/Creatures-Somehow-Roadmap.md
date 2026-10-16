# Creatures, Somehow — Development Checklist

Updated October 12, 2026.

Working roadmap, not a deadline promise. Check completed tasks with `- [x]`. Unchecked items include existing features that still need verification; they do not imply nothing has been implemented.

Alpha: trustworthy engine. Beta: living individuals. Release: emergent stories. Post-release: genetics and expanded tooling. Community work runs in parallel.

## Alpha

Make the foundation trustworthy.

Groundwork only for advanced AI and future features. Defer genetics, elaborate memories, combat, the visual mod editor, and birthday parties.

### Engine and architecture

- [ ] Finish universal data driven creature JSON system
- [ ] Finish and validate creature schemas
- [ ] Simple defaults and optional detailed overrides
- [ ] Integer pixel coordinate anchors
- [ ] Allow anchors outside sprite bounds
- [ ] Separate animated anchor positions from interaction reach
- [ ] Finish surface system
- [ ] Persistent surface IDs
- [ ] Require appropriate surface and Y matching for interactions
- [ ] Prevent ground interactions across disconnected surfaces
- [ ] Finalize transparent pixel hit testing
- [ ] Cache alpha masks if profiling warrants it
- [ ] Finish reusable Behavior Need and POI architecture
- [ ] Keep behaviors generic rather than species specific

### Existing Alpha functionality

- [ ] Fresh random rat spawning
- [ ] Field Guide spawning
- [ ] Live 1x to 4x scale
- [ ] Always On Top
- [ ] Persist settings
- [ ] Clean up test food water and rat behavior
- [ ] Keep Field Guide simple for Alpha
- [ ] Bug and diagnostic tests
- [ ] Verify packaged assets and publishing

### New groundwork

- [ ] Stable persistent entity IDs
- [ ] Namespaced definition IDs such as base:rat and base:berry
- [ ] Decide save schema and versioning format
- [ ] Reusable validation service
- [ ] Unit tests for schemas and validators
- [ ] Structured diagnostics with technical and human readable views

## Beta

Make the creatures live.

### Creature trio

- [ ] Rat
- [ ] Squirrel
- [ ] Hummingbird
- [ ] Generic support for ground climbing and flying differences

### Needs and utility AI

- [ ] Stage 1 action eligibility
- [ ] Stage 2 utility scoring
- [ ] Hunger
- [ ] Rest and sleep
- [ ] Exploration
- [ ] Gathering
- [ ] Creature awareness
- [ ] Interrupt actions for important events
- [ ] Action commitment and cooldowns
- [ ] Profile decision scheduling and CPU use

### Individual personalities

- [ ] Original temperament
- [ ] Current evolving personality
- [ ] Numeric traits including curiosity bravery mischievousness and sociability
- [ ] Traits influence utility
- [ ] Experiences can permanently alter personality
- [ ] Preserve original temperament
- [ ] Generate unique individuals worth naming and saving

### Preferences

- [ ] Favorites
- [ ] Likes
- [ ] Neutral preferences
- [ ] Dislikes
- [ ] Absolute refusals
- [ ] Hunger can outweigh dislikes
- [ ] Hard refusals fail eligibility
- [ ] Preferences affect utility
- [ ] Allow later learned preferences

### Memory system

- [ ] One generic memory engine
- [ ] Specific object memories
- [ ] Specific creature memories
- [ ] Generalized category memories
- [ ] Store IDs type strength and numeric game timestamp
- [ ] Calculate half life decay when queried
- [ ] No constantly ticking memory records
- [ ] Reinforce repeated memories
- [ ] Bound and prune insignificant memories
- [ ] Favorite locations and resources
- [ ] Danger memories
- [ ] Successful hiding feeding and other experiences
- [ ] Generalize individual encounters to categories

### Relationships

- [ ] Create records after meaningful interaction
- [ ] Avoid an all creature relationship matrix
- [ ] Allow asymmetric relationships
- [ ] Friendship and affection
- [ ] Fear
- [ ] Rivalry and hostility
- [ ] Familiarity
- [ ] Relationships affect utility
- [ ] Use the shared interaction engine

### Generic events

- [ ] Decisions select intentions
- [ ] Interactions execute intentions
- [ ] Events report outcomes rather than decide them
- [ ] Food discovered
- [ ] Resource consumed
- [ ] Threat encountered
- [ ] Chase started
- [ ] Escape succeeded
- [ ] Positive interaction
- [ ] Shelter discovered
- [ ] Systems react only to relevant events

### Gathering and resources

- [ ] Gatherable objects
- [ ] Berry bush regrowth
- [ ] Acorn and other resource respawn
- [ ] Cute gathering animations
- [ ] Optional Instant Gathering setting
- [ ] Storage container
- [ ] Clearing the desktop preserves gathered resources
- [ ] Resource persistence

### Worlds and saves

- [ ] Multiple world save slots
- [ ] Separate world configurations
- [ ] Cute chill world preset
- [ ] Chaos and mass spam possibilities
- [ ] Feature configuration within one engine
- [ ] Limited eligible resource accumulation while inactive
- [ ] No offline ecosystem simulation
- [ ] Versioned save schema
- [ ] Safe atomic writes
- [ ] Backups and recovery
- [ ] Preserve unknown fields across read and write
- [ ] Missing mods preserve creature data
- [ ] Careful migrations with recovery paths

### Performance

- [ ] Basic wanderer tier for mass creature chaos
- [ ] Full brain simulation tier
- [ ] Nearby entity queries
- [ ] Event driven updates
- [ ] Scheduled infrequent AI decisions
- [ ] Bounded memories and relationship records
- [ ] Efficient ID lookup
- [ ] Profile large creature counts
- [ ] Measure CPU RAM and frame times with ordinary desktop applications running

## Release 1 0

Turn the ecosystem into a game.

### Full ecosystem

- [ ] Larger creature roster
- [ ] Animals insects and magical creatures
- [ ] Discovery
- [ ] Exploration
- [ ] Gathering
- [ ] Crafting
- [ ] Puzzles and interactions
- [ ] Creature caused environment changes
- [ ] Nest and building behaviors
- [ ] Appropriate weather and environment systems

### Predator and prey

- [ ] Peaceful mode with no hunting
- [ ] Playful harmless chases and pounces
- [ ] Survival injuries and recovery without death
- [ ] Wild mode allowing death
- [ ] Predation stays a free core mechanic
- [ ] Utility based predator targeting
- [ ] Prey threat responses
- [ ] Run hide fight and freeze options
- [ ] Movement based chases
- [ ] Generic encounter and combat resolution
- [ ] Relationships can change predator prey behavior

### Death and revival

- [ ] Death never deletes saved creatures
- [ ] Inactive dead state
- [ ] Revival item
- [ ] Consider automatic revival world option
- [ ] Preserve personality
- [ ] Preserve memories
- [ ] Preserve relationships
- [ ] Preserve creature history

### Emergent stories

- [ ] Record important milestones in creature history
- [ ] Personal biographies in the Field Guide
- [ ] Parent and birth records when breeding exists
- [ ] Friends and rivals
- [ ] Favorite foods
- [ ] Major discoveries
- [ ] Survived attacks
- [ ] Death and revival history
- [ ] Other meaningful milestones

### Random encounters

- [ ] Rare world events
- [ ] Special visitors
- [ ] Unusual behaviors
- [ ] Blood moon style event
- [ ] Rare and event specific creatures
- [ ] Mysterious glowing orb encounters
- [ ] Creature targeted events
- [ ] Discoverable secrets

### Birthday celebrations

- [ ] Optional birthday setting
- [ ] Store only month and day
- [ ] Creature celebrations
- [ ] Party behaviors
- [ ] Tiny party hats
- [ ] Disable feature and delete birthday information

## Post release

Expand without delaying version 1 0.

### Genetics and breeding

- [ ] Breeding
- [ ] Parent tracking
- [ ] Genetic inheritance
- [ ] Temperament inheritance
- [ ] Variation and mutation
- [ ] Appearance inheritance
- [ ] Species specific breeding rules
- [ ] Future crossbreeding
- [ ] Hybrid definitions
- [ ] Dragon Rat

### Physical simulation

- [ ] Weight attribute
- [ ] Food and activity affect weight
- [ ] Body condition effects
- [ ] Future alternate fat and thin sprites
- [ ] Defer large sprite variant sets

### Public modding support

- [ ] Public schema documentation
- [ ] Creature definition documentation
- [ ] Community namespaces
- [ ] Dependency handling
- [ ] Preserve missing mod data
- [ ] Validate mods before loading
- [ ] Human readable validation errors
- [ ] Expandable technical diagnostics
- [ ] Stable error codes and wiki explanations
- [ ] Example mods
- [ ] Validate assets references behaviors and defaults
- [ ] Content mods
- [ ] Configuration mods
- [ ] Defer executable code mods for later evaluation

### Visual mod creator

- [ ] Creature creation interface
- [ ] Checklist and wizard
- [ ] Import sprites and assets
- [ ] Clearly mark required fields
- [ ] Defaults for optional settings
- [ ] Personality editor
- [ ] Behavior editor
- [ ] Preference editor
- [ ] Animation configuration
- [ ] Interaction configuration
- [ ] Validation during editing
- [ ] Validate Mod button
- [ ] Export a ready to use mod package
- [ ] Share validation services across game editor and tests

## Community and business

Parallel track.

### Website and distribution

- [x] Register creaturessomehow.com
- [ ] Basic hand coded homepage
- [ ] Link game site to paulinagreybyrd.dev
- [ ] Link portfolio back to game site
- [ ] AWS hosting and domain connection
- [ ] Future direct purchase and downloads alongside Steam
- [ ] Wiki and documentation
- [ ] Modding documentation route
- [ ] Community mod documentation
- [ ] Generate field reference documentation from schemas

### Credits and licensing

- [ ] Credits and acknowledgments section
- [ ] Internal asset attribution and license manifest
- [ ] Record creator source URL license version attribution requirements and usage
- [ ] Generous creator credits
- [ ] Check third party asset license records before release

### Business principles

- [ ] No real money gameplay or shop mechanics
- [ ] Paid DLC provides content rather than fundamental ecosystem mechanics

