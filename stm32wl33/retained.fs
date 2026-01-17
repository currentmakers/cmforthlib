\
\ @file retained.fs
\ @brief RFIP_WAKEUPTIME register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RETAINED_DEF

  [ifdef] RETAINED_RFIP_WAKEUPTIME_DEF
    \
    \ @brief RFIP_WAKEUPTIME register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RETAINED_RFIP_WAKEUPTIME       \ [0x00 : 32] (Absolute) Target time to wakeup the RFIP.
  [then]


  [ifdef] RETAINED_CPU_WAKEUPTIME_DEF
    \
    \ @brief CPU_WAKEUPTIME register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $01 constant RETAINED_CPU_WAKEUPTIME        \ [0x01 : 31] (Absolute) Target time to wakeup the CPU.
  [then]


  [ifdef] RETAINED_WAKEUP_CTRL_DEF
    \
    \ @brief WAKEUP_CTRL register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RETAINED_SOC_WAKEUP_OFFSET     \ [0x00 : 8] Delay to be considered by the Wakeup block to anticipate the wakeup request to the PWRC of the SoC versus the target to wakeup the RFIP (or the CPU).
    $1e constant RETAINED_CPU_WAKEUP_EN         \ [0x1e] Indicates if the wakeup timer has to wakeup the SoC (match on CPU_WAKEUPTIME[31:4] bit field only) + set the CPU_WAKEUP_F in the WAKEUP_IRQ_STATUS Misc register when match on CPU_WAKEUPTIME[31:0] occurs.
    $1f constant RETAINED_RFIP_WAKEUP_EN        \ [0x1f] Indicates if the wakeup timer has to wakeup the SoC (match on RFIP_WAKEUPTIME[31:4] bit field only) + trigger an event on the Sequencer and set the RFIP_WAKEUP_F in the WAKEUP_IRQ_STATUS Misc register when match on RFIP_WAKEUPTIME[31:0] occurs.
  [then]


  [ifdef] RETAINED_RRM_CMDLIST_PTR_DEF
    \
    \ @brief RRM_CMDLIST_PTR register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant RETAINED_CMDLIST_PTR_OFFSET    \ [0x00 : 16] Contain the offset versus the SoC RAM base address where to find the RRM-UDRA command list entry point.
    $1f constant RETAINED_CMDLIST_PTR_VALID     \ [0x1f] Indicate if a command list has to be executed or not
  [then]


  [ifdef] RETAINED_SEQ_GLOBALTABLE_PTR_DEF
    \
    \ @brief SEQ_GLOBALTABLE_PTR register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RETAINED_SEQ_GLOBALTABLE_PTR   \ [0x00 : 16] Contain the offset versus the SoC RAM base address of the GlobalConfiguration RAM table entry point.
  [then]

  \
  \ @brief RFIP_WAKEUPTIME register
  \
  $00 constant RETAINED_RFIP_WAKEUPTIME \ RFIP_WAKEUPTIME register
  $04 constant RETAINED_CPU_WAKEUPTIME  \ CPU_WAKEUPTIME register
  $08 constant RETAINED_WAKEUP_CTRL     \ WAKEUP_CTRL register
  $0C constant RETAINED_RRM_CMDLIST_PTR \ RRM_CMDLIST_PTR register
  $10 constant RETAINED_SEQ_GLOBALTABLE_PTR    \ SEQ_GLOBALTABLE_PTR register

: RETAINED_DEF ; [then]
